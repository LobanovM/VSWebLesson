using System.Web.Mvc;
using Omu.Awesome.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Ch04_Awesome.App_Start.MvcProjectAwesome), "Start")]
namespace Ch04_Awesome.App_Start
{    
    public static class MvcProjectAwesome
    {
        public static void Start()
        {
            ModelMetadataProviders.Current = new AwesomeModelMetadataProvider();
        }
    }
}