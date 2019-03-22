using ASPNETCore_Assignments.Persistence;
using ASPNETCore_Assignments.Persistence.Data;
using ASPNETCore_Assignments.Reository;
using ASPNETCore_Assignments.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ASPNETCore_Assignments
{
  public class Startup
  {
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
    {
			var appSetting = Configuration.Get<AppSettings>();

			services.Configure<AppSettings>(Configuration);
			services.AddDbContext<SchoolManagementContext>(options =>
					options.UseSqlServer(appSetting.ConnectionStrings.DefaultConnection));
			services.AddDistributedMemoryCache();
			services.AddSession(options =>
			{
				options.IdleTimeout = TimeSpan.FromMinutes(20);
				options.Cookie.HttpOnly = false;
			});

			services.AddSingleton<IPersonRepository, InMemoryPersonRepository>();

			services.AddMvc()
				.SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
    }
		
    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
			}
      app.UseStaticFiles();
			app.UseSession();

			app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}
