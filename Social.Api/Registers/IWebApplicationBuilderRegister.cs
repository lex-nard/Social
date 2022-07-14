namespace Social.Api.Registers
{
    public interface IWebApplicationBuilderRegister : IRegister
    {
        public void RegisterServices(WebApplicationBuilder builder);
    }
}
