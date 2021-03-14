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


            //세션관련 
            services.AddDistributedMemoryCache(); 
            services.AddSession(options => { 
                // Set a short timeout for easy testing. 
                options.IdleTimeout = TimeSpan.FromSeconds(10); 
                options.Cookie.HttpOnly = true; 
                // Make the session cookie essential 
                options.Cookie.IsEssential = true; 
            });           

            /*
            Transient  : Transient 수명 서비스(AddTransient)는 서비스 컨테이너에서 요청할 때마다 만들어집니다. 이 수명은 간단한 상태 비저장 서비스에 가장 적합합니다.
                        -> 매번 인스턴스를 새로 생성하기 때문에 모든 값은 초기값으로 설정됩니다. 
            Scoped : Scoped 수명 서비스(AddScoped)는 클라이언트 요청(연결)당 한 번 생성됩니다.
                        - 클라이언트 요청당 한번 생성이 되며, 해당 연결이 유지되면 지속적으로 사용합니다.
                        - 요청 내에서 상태를 유지하려는 경우 좋습니다.

            Singleton : 싱글톤 수명 서비스(AddSingleton)는 처음 요청할 때(또는 Startup.ConfigureServices를 실행하고 서비스 등록에서 인스턴스를 지정하는 경우) 
                        생성됩니다. 모든 후속 요청에서는 같은 인스턴스를 사용합니다. 앱에 싱글톤 동작이 필요한 경우 서비스 컨테이너가 서비스 수명을 관리하도록 
                        허용하는 것이 좋습니다. 싱글톤 디자인 패턴을 구현하거나 클래스의 개체 수명을 관리하는 사용자 코드를 제공하지 마세요.

                        - 인스턴스 하나로 지속적으로 재활용합니다.
                        - 어플리케이션 전체 상태를 유지해야 하는 경우 싱클톤을 사용하십시오.

            */
            //HolidaysApiService 를 사용하려면 먼저 Startup.cs 클래스에 서비스를 등록해야합니다 .
            services.AddSingleton<IHolidaysApiService, HolidaysApiService>();

            // HttpClient 인스턴스를 관리 가능 하게 만들고  위에서 언급 한 소켓 소모 문제를 방지하기 위해 .NET Core 2.1은 DI(종속성 주입)를 
            // 통해 앱에서 HttpClient 인스턴스를 구성하고 만드는 데 사용할 수있는 IHttpClientFactory 인터페이스를 도입했습니다.IHttpClientFactory 를 
            // 사용하려면 AddHttpClient(IServiceCollection) 을 호출하여 Startup.cs 파일에 등록 할 수 있습니다  .
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

            //셔션관련  
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
