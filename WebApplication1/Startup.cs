using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WebApplication1.Managers.Countrys;
using WebApplication1.Managers.Citys;
using WebApplication1.Managers.Restaurants;
using WebApplication1.Managers.Verandas;
using WebApplication1.Managers.Menus;
using WebApplication1.Managers.Products;
using WebApplication1.Managers.Foods;
using WebApplication1.Storage;

namespace WebApplication1
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("ProductDbSettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductDataContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("ProductDb")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<ICountryManager, CountryManager>();
            services.AddTransient<ICityManager, CityManager>();
            services.AddTransient<IRestaurantManager, RestaurantManager>();
            services.AddTransient<IVerandaManager, VerandaManager>();
            services.AddTransient<IMenuManager, MenuManager>();
            services.AddTransient<IFoodManager, FoodManager>();
            services.AddTransient<IProductManager, ProductManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Country}/{action=ShowCountrys}/{id?}");
            });

        }
    }
}
