namespace Social.Api
{
    public class ApiRoutes
    {
        public const string BaseRoute = "api/v{version:apiVersion}/[controller]";

        public const string GeneralIdRoute = "{id}";

        public class UserProfiles
        {
            public const string IdRoute = "{id}";
        }

        
    }
}
