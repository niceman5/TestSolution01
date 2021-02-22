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
        // launchSettings.json �����ϴ°� ����.
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
                 *  �⺻���� ����� �� �ֽ��ϴ� { controller = "Blog", action = "Article" } .
                    �� ��δ� �׻� �۾��� ���ε˴ϴ� BlogController.Article .
                    /Blog, /Blog/Article �� /Blog/{any-string} �� ��α� ��ο� ��ġ �ϴ� ������ URL ����Դϴ�.

                    blog ��δ� default ���� �߰� �Ǳ� ������ ��� ���� ��ġ �ϴ� �׸� �� �� �켱 ������ �����ϴ�

                 * */

                endpoints.MapControllerRoute(
                    name:"blog",
                    pattern: "blog/{*article}",
                    defaults: new { controller="Blog", action= "Article" });
                
                // �Ϲ������� �⺻ ������������ ��
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
