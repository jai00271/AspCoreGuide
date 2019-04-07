namespace ProjectBasicSetup.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtensions
    {
        /// <summary>
        /// we need to configure CORS in our application. CORS (Cross-Origin Resource Sharing) is a mechanism that gives rights to the user to access resources from the 
        /// server on a different domain. Because we will use Angular as a client-side on a different domain than server’s domain, configuring CORS is mandatory.
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            //We are using the basic settings for adding CORS policy because for this project allowing any origin, method, and header is quite enough. 
            //But you can be more restrictive with those settings if you want. Instead of the AllowAnyOrigin() method which allows requests from any source, 
            //you could use the WithOrigins("http://www.something.com") which will allow requests just from the specified source. 
            //Also, instead of AllowAnyMethod() that allows all HTTP methods,  you can use WithMethods("POST", "GET") that will allow only specified HTTP methods.
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }
        /// <summary>
        /// Inject all services here instead of doing it in Startup.cs
        /// </summary>
        /// <param name="services"></param>
        public static void InjectServices(this IServiceCollection services)
        {

        }
    }
}