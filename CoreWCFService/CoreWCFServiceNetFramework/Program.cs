namespace CoreWCFService
{
    using CoreWCF;
    using CoreWCF.Configuration;
    using CoreWCF.Description;
    using Microsoft.AspNetCore.Builder;
    using CoreWCFService;
    using CoreWCF.Channels;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().UseUrls("https://localhost:7212").Build().Run();
            /*
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddServiceModelServices();
            builder.Services.AddServiceModelMetadata();
            builder.Services.AddSingleton<IServiceBehavior,
            UseRequestHeadersForMetadataAddressBehavior>();
            var app = builder.Build();
            app.Urls.Add("https://localhost:7212"); // To correctly publish endpoint https://localhost:7212/Service.svc from output directory
            app.UseServiceModel(bld =>
            {
                bld.AddService<Service>();
                bld.AddServiceEndpoint<Service, IService>(new BasicHttpBinding(
                    BasicHttpSecurityMode.Transport), "/Service.svc");
                var mb = app.Services.GetRequiredService<ServiceMetadataBehavior>();
                mb.HttpsGetEnabled = true;
            });
            app.Run();
            */
        }
    }
}