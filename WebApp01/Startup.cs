using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp01.Data;
using WebApp01.Models;
using WebApp01.Models.Holiday;

namespace WebApp01
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("Default")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();


            //���ǰ��� 
            services.AddDistributedMemoryCache(); 
            services.AddSession(options => { 
                // Set a short timeout for easy testing. 
                options.IdleTimeout = TimeSpan.FromSeconds(10); 
                options.Cookie.HttpOnly = true; 
                // Make the session cookie essential 
                options.Cookie.IsEssential = true; 
            });           

            /*
            Transient  : Transient ���� ����(AddTransient)�� ���� �����̳ʿ��� ��û�� ������ ��������ϴ�. �� ������ ������ ���� ������ ���񽺿� ���� �����մϴ�.
                        -> �Ź� �ν��Ͻ��� ���� �����ϱ� ������ ��� ���� �ʱⰪ���� �����˴ϴ�. 
            Scoped : Scoped ���� ����(AddScoped)�� Ŭ���̾�Ʈ ��û(����)�� �� �� �����˴ϴ�.
                        - Ŭ���̾�Ʈ ��û�� �ѹ� ������ �Ǹ�, �ش� ������ �����Ǹ� ���������� ����մϴ�.
                        - ��û ������ ���¸� �����Ϸ��� ��� �����ϴ�.

            Singleton : �̱��� ���� ����(AddSingleton)�� ó�� ��û�� ��(�Ǵ� Startup.ConfigureServices�� �����ϰ� ���� ��Ͽ��� �ν��Ͻ��� �����ϴ� ���) 
                        �����˴ϴ�. ��� �ļ� ��û������ ���� �ν��Ͻ��� ����մϴ�. �ۿ� �̱��� ������ �ʿ��� ��� ���� �����̳ʰ� ���� ������ �����ϵ��� 
                        ����ϴ� ���� �����ϴ�. �̱��� ������ ������ �����ϰų� Ŭ������ ��ü ������ �����ϴ� ����� �ڵ带 �������� ������.

                        - �ν��Ͻ� �ϳ��� ���������� ��Ȱ���մϴ�.
                        - ���ø����̼� ��ü ���¸� �����ؾ� �ϴ� ��� ��Ŭ���� ����Ͻʽÿ�.

            */
            //HolidaysApiService �� ����Ϸ��� ���� Startup.cs Ŭ������ ���񽺸� ����ؾ��մϴ� .
            services.AddSingleton<IHolidaysApiService, HolidaysApiService>();

            // HttpClient �ν��Ͻ��� ���� ���� �ϰ� �����  ������ ��� �� ���� �Ҹ� ������ �����ϱ� ���� .NET Core 2.1�� DI(���Ӽ� ����)�� 
            // ���� �ۿ��� HttpClient �ν��Ͻ��� �����ϰ� ����� �� ����� ���ִ� IHttpClientFactory �������̽��� �����߽��ϴ�.IHttpClientFactory �� 
            // ����Ϸ��� AddHttpClient(IServiceCollection) �� ȣ���Ͽ� Startup.cs ���Ͽ� ��� �� �� �ֽ��ϴ�  .
            services.AddHttpClient("PublicHolidaysApi", c => c.BaseAddress = new Uri("https://date.nager.at"));

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(15);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //�żǰ���  
            app.UseSession();           

        

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
