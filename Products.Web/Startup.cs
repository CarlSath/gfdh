using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Daos.SqlServer;
using Products.Daos;
using Products.Services;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Web
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;

            string connectionString = this.Configuration.GetConnectionString("Products");
            DaoFactory.Instance.ConnectionStringBuilder = new ConnectionStringBuilder(connectionString, typeof(SqlContext)){SqlDialectType = typeof(SqlServerDialect), SqlDialectVersionType = typeof(SqlServerDialectVersion)};

            RegisterDaos.RegisterAll(DaoFactory.Instance.ConnectionStringBuilder.SqlDialectType, DaoFactory.Instance.ConnectionStringBuilder.SqlDialectVersionType);
            RegisterServices.RegisterAll();           
            /*add customized code between this region*/
            /*add customized code between this region*/
            //this.RegisterView();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=School}/{action=Index}/{id?}");

            });
        }
        /*add customized code between this region*/
        /*add customized code between this region*/
    }
}
