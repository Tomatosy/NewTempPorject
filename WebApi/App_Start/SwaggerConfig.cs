using System.Web.Http;
using Swashbuckle.Application;
using System.Linq;
using System.Reflection;
using System.Web;
using WebApi;
using Tomato.NewTempProject.WebApi;

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

                    c.SingleApiVersion("v6.66", "Tomato.NewTempProject.WebApi.Swagger");

                    string xmlFile1 = string.Format("{0}/App_Data/Tomato.NewTempProject.WebApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
                    string xmlFile2 = string.Format("{0}/App_Data/Tomato.NewTempProject.Model.XML", System.AppDomain.CurrentDomain.BaseDirectory);
                    if (System.IO.File.Exists(xmlFile1))
                    {
                        c.IncludeXmlComments(xmlFile1);
                    }
                    if (System.IO.File.Exists(xmlFile2))
                    {
                        c.IncludeXmlComments(xmlFile2);
                    }
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    c.CustomProvider((defaultProvider) => new SwaggerControllerDescProvider(defaultProvider, xmlFile1));
                })
                .EnableSwaggerUi(c =>
                {
                    c.InjectJavaScript(Assembly.GetExecutingAssembly(), "Tomato.NewTempProject.WebApi.Scripts.SwaggerConfig.js");
                });
        }
    }
}
