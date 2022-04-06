using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_mvc_01
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllersWithViews();
        }
       public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //abc.com 
                //abc.com/urunler
                //abc.com/urunler7/getir
                //abc.com/urunler7/getir/5
            });

            ma();
                   
        
        
        }
        public int ma()
        {


            return 1;
        }
        class s{ }

             

    }
}