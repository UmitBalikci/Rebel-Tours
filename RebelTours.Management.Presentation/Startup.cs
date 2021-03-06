using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RebelTours.Management.Application.Buses;
using RebelTours.Management.Application.BusManufacturers;
using RebelTours.Management.Application.BusModels;
using RebelTours.Management.Application.Cities;
using RebelTours.Management.Application.Repositories;
using RebelTours.Management.Application.Stations;
using RebelTours.Management.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelTours.Management.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICityRepository, CityRepository>();

            services.AddTransient<IStationService, StationService>();
            services.AddTransient<IStationRepository, StationRepository>();

            services.AddTransient<IBusModelService, BusModelService>();
            services.AddTransient<IBusModelRepository, BusModelRepository>();

            services.AddTransient<IBusManufacturerService, BusManufacturerService>();
            services.AddTransient<IBusManufacturerRepository, BusManufacturerRepository>();

            services.AddTransient<IBusService, BusService>();
            services.AddTransient<IBusRepository, BusRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
