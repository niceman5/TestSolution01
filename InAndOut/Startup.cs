using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // launchSettings.json 참조하는거 같음.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                /*
                 *  https://docs.microsoft.com/ko-kr/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0
                 *  
                 *  기본값만 사용할 수 있습니다 { controller = "Blog", action = "Article" } .
                    이 경로는 항상 작업에 매핑됩니다 BlogController.Article .
                    /Blog, /Blog/Article 및 /Blog/{any-string} 은 블로그 경로와 일치 하는 유일한 URL 경로입니다.

                    blog 경로는 default 먼저 추가 되기 때문에 경로 보다 일치 하는 항목에 대 한 우선 순위가 높습니다

                 * */

                endpoints.MapControllerRoute(
                    name:"blog",
                    pattern: "blog/{*article}",
                    defaults: new { controller="Blog", action= "Article" });
                
                // 일반적으로 기본 라우팅을사용할 때
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
