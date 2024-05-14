using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.Business.Concrete;
using DavaSurecTakip.DataAccess.Abstract;
using DavaSurecTakip.DataAccess.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DavaSurecTakip.UI
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
            
            services.AddScoped<IUsersService, UsersManager>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddScoped<IPaidDamagesService, PaidDamagesManager>();
            services.AddScoped<IPaidDamagesRepository, PaidDamagesRepository>();

            services.AddScoped<ICaseService, CaseManager>();
            services.AddScoped<ICaseRepository, CaseRepository>();

            services.AddScoped<ILookupAttornerLService, LookupAttornerLManager > ();
            services.AddScoped<ILookupAttornerLRepository, LookupAttornerLRepository>();

            services.AddScoped<ILookupCaseResultLService, LookupCaseResultLManager>();
            services.AddScoped<ILookupCaseResultLRepository, LookupCaseResultLRepository>();

            services.AddScoped<ILookupCaseSubjectLService, LookupCaseSubjectLManager>();
            services.AddScoped<ILookupCaseSubjectLRepository, LookupCaseSubjectLRepository>();

            services.AddScoped<ILookupCourtInfoLService, LookupCourtInfoLManager>();
            services.AddScoped<ILookupCourtInfoLRepository, LookupCourtInfoLRepository>();

            services.AddScoped<ILookupDamageTypeLService, LookupDamageTypeLManager>();
            services.AddScoped<ILookupDamageTypeLRepository, LookupDamageTypeLRepository>();

            services.AddScoped<ILookupFileDamageStatusLService, LookupFileDamageStatusLManager>();
            services.AddScoped<ILookupFileDamageStatusLRepository, LookupFileDamageStatusLRepository>();

            services.AddScoped<ILookupFileStageLService, LookupFileStageLManager>();
            services.AddScoped<ILookupFileStageLRepository, LookupFileStageLRepository>();

            services.AddScoped<ILookupInsuranceExplanationLService, LookupInsuranceExplanationLManager>();
            services.AddScoped<ILookupInsuranceExplanationLRepository, LookupInsuranceExplanationLRepository>();

            services.AddScoped<ILookupLevyInfoLService, LookupLevyInfoLManager>();
            services.AddScoped<ILookupLevyInfoLRepository, LookupLevyInfoLRepository>();

            services.AddScoped<ILookupPaymentTypeLService, LookupPaymentTypeLManager>();
            services.AddScoped<ILookupPaymentTypeLRepository, LookupPaymentTypeLRepository>();

            services.AddScoped<ILookupProvinceLService, LookupProvinceLManager>();
            services.AddScoped<ILookupProvinceLRepository, LookupProvinceLRepository>();

            services.AddScoped<ILookupWorkAreaLService, LookupWorkAreaLManager>();
            services.AddScoped<ILookupWorkAreaLRepository, LookupWorkAreaLRepository>();

            services.AddMvc();
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
              AddCookie(x =>
              {
                  x.LoginPath = "/LoginUI/LogIndex/";
              });

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=LoginUI}/{action=LogIndex}/{id?}");
            });
        }
    }
}
