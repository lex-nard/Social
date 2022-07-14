using Social.Api.Registers;

namespace Social.Api.Extensions
{
    public static class RegisterExtensions
    {
        public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
        {
            var registers = GetRegister<IWebApplicationBuilderRegister>(scanningType);

            foreach (var register in registers)
            {
                register.RegisterServices(builder);
            }
        }

        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registers = GetRegister<IWebApplicationRegister>(scanningType);

            foreach (var register in registers)
            {
                register.RegisterPipelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegister<T>(Type scanningType) where T : IRegister
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) &&
                !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
