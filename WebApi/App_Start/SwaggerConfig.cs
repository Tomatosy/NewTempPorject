using System.Web.Http;
using Swashbuckle.Application;
using System.Linq;
using System.Reflection;
using System.Web;
using WebApi;
using SeaSky.NewTempProject.WebApi;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            Assembly thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1.1", "SeaSky.NewTempProject.WebApi");

                    string xmlFile = string.Format("{0}/App_Data/SeaSky.NewTempProject.WebApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
                    if (System.IO.File.Exists(xmlFile))
                    {
                        c.IncludeXmlComments(xmlFile);
                    }
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    c.CustomProvider((defaultProvider) => new SwaggerControllerDescProvider(defaultProvider, xmlFile));
                })
                .EnableSwaggerUi(c =>
                {
                    c.InjectJavaScript(Assembly.GetExecutingAssembly(), "SeaSky.NewTempProject.WebApi.Scripts.SwaggerConfig.js");

                });
        }
    }
}
