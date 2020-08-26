using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.WebApi

{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        /*add customized code between this region*/
        /*add customized code between this region*/
    }
}