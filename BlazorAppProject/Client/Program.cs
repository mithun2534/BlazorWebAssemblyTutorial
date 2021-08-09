using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDg1OTMyQDMxMzkyZTMyMmUzMEdkQ29IZU1MdGZnRWc0ME92cjJRc0VKVGpaNCtmeEhKLzkwR0VHQjRFcE09;NDg1OTMzQDMxMzkyZTMyMmUzMExQZjhxSldqQndIVTRWY3pWL3lvdVZTVG5XdXovR1puTXFoTGNmR2ZuTlU9;NDg1OTM0QDMxMzkyZTMyMmUzMFVuNDRsUksrc0N1RUdBL2lTT29BWVFPdGFUR2FadVlpVmVELzRHY2lQb289;NDg1OTM1QDMxMzkyZTMyMmUzMFNpWklFcXA4Z3h4TVpncVgrVjBPQlNJcFlkeFpydjBMWGZtaEEvZ3JRM009;NDg1OTM2QDMxMzkyZTMyMmUzMG15OGFXQ3ZGbk13Q0MwN1ZIR3pCeG5NdEo3aEJDWVNNSWozZW11ajZFdms9;NDg1OTM3QDMxMzkyZTMyMmUzMGRKZXh1L2QrRnpjVUR5cHFTUmI2NlZnQnVCVy9pQ05tbFBDdTVqQUZQbWc9;NDg1OTM4QDMxMzkyZTMyMmUzMFRTV1R5OWc2QlF2bkswWEdtaGltYS9KTTIzL2t4YWRIZ09CTThpMXNJdWM9;NDg1OTM5QDMxMzkyZTMyMmUzMGsvMmwxQTF4YWlCenY4UDA4ZDg1L0NuMitKQlFnbm8reHJyWmIrT2dtUTQ9;NDg1OTQwQDMxMzkyZTMyMmUzMElSNjBGWjFzTjQxTFJDQ25ReWNvazBEU1AxVVlQcDRscjArdWx6cDJ2cG89;NDg1OTQxQDMxMzkyZTMyMmUzMGlNMjc5N3plc3I1MlJ5b04zVlhjVnIySUlERlkxU2NGaFVBYXFsTkk5ckk9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
