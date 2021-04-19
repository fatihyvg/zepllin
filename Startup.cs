using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using zepllin.EmailConfig;
using zepllin.Interfaces;
using zepllin.Database;
using zepllin.Models;
using zepllin.Extra;
namespace zepllin
{
    public class Startup
    {
        public Startup()
        {
            ConfigurationBuilder config = new ConfigurationBuilder();
            config.SetBasePath(Directory.GetCurrentDirectory());
            config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = config.Build();
        }
        public IConfiguration Configuration
        {
            get;
        }
        public void ConfigureServices(IServiceCollection services)    
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Latest);
            services.AddControllersWithViews().AddJsonOptions(json =>
            {
                json.JsonSerializerOptions.DictionaryKeyPolicy = null;
                json.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
            services.AddHsts(hsts =>
            {
                hsts.Preload = false;
                hsts.IncludeSubDomains = false;
                hsts.MaxAge = TimeSpan.FromDays(30);
                hsts.ExcludedHosts.Add("zepllin.com");
                hsts.ExcludedHosts.Add("www.zepllin.com");
            });
            services.AddHttpsRedirection(https =>
            {
                https.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                https.HttpsPort = 5001;
            });
            services.Configure<RazorViewEngineOptions>(raz =>
            {
                raz.AreaViewLocationFormats.Clear();
                raz.AreaViewLocationFormats.Add("~/Areas/{2}/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                raz.AreaViewLocationFormats.Add("~/Areas/{2}/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                raz.AreaViewLocationFormats.Add("~/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
                raz.ViewLocationFormats.Clear();
                raz.ViewLocationFormats.Add("~/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                raz.ViewLocationFormats.Add("~/Views/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
            //services.AddAntiforgery(x => x.HeaderName = "X-XSRF-TOKEN");
            services.AddControllersWithViews(filter =>
            {
                filter.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            services.AddDistributedMySqlCache(cacheopt =>
            {
                cacheopt.ConnectionString = DatabaseContext.GetConnString;
                cacheopt.SchemaName = "zepllin";
                cacheopt.TableName = "sqlcache";

            });
            services.AddDbContext<DatabaseContext>();
            services.AddAuthentication();
            services.AddIdentity<CreateUsers, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = true;  
                opt.Password.RequiredLength = 8;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireNonAlphanumeric = false;
                opt.User.RequireUniqueEmail = true;
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";

            }).AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.Cookie.Name = "zepllin.cookie";
                cookie.LoginPath = new PathString("/Account/SignIn");
                cookie.AccessDeniedPath = new PathString("/Home/AccessDenied");
                cookie.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                cookie.Cookie.SameSite = SameSiteMode.Strict;
            });
            services.AddSession(session =>
            {
                session.Cookie.Name = "zepllin.session";
                session.Cookie.MaxAge = TimeSpan.FromMinutes(20);
                session.IdleTimeout = TimeSpan.FromMinutes(20);
            });
            //services.Configure<ForwardedHeadersOptions>(forwardedopt =>
            //{
            //    forwardedopt.KnownProxies.Add(IPAddress.Parse("127.0.0.1")); /* TODO burada publish etmeden önce ip değişimi yapılacak*/
            //});
            services.AddScoped<IAdminLogin, AdminLogin>();
            services.AddScoped<IdentityUser, CreateUsers>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IForgotPassword, ForgotPassword>();
            services.AddScoped<IChangePassword, ChangePassword>();
            services.AddScoped<INormalLogin, NormalLogin>();
            services.AddScoped<INormalUserRole, NormalUserRole>();
            services.AddScoped<ICategory, Category>();
            services.AddScoped<IUserImages, UserImages>();
            services.AddScoped<IDatabaseRepository<Category>, DatabaseRepository<Category>>();
            services.AddScoped<IDatabaseRepository<UserImages>, DatabaseRepository<UserImages>>();
            services.AddScoped<IDatabaseRepository<Vote>, DatabaseRepository<Vote>>();
            services.AddScoped<IDatabaseRepository<Comments>,DatabaseRepository<Comments>>();
            services.AddScoped<IJsonCache<Category>, JsonCache<Category>>();
            services.AddScoped<IJsonCache<UserImages>, JsonCache<UserImages>>();
            services.AddScoped<IVote, Vote>();
            services.AddScoped<IComments, Comments>();
            services.AddSingleton<INormalUser, NormalUser>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) /*TODO publish etmeden önce productiona alıanacak önemli kısım IsProduction() olarak*/
            {
                app.UseHttpsRedirection();
                app.UseRouting();
                app.UseStaticFiles(CssAndContentFiles);
                app.UseStaticFiles(ImageFiles);             
                app.UseForwardedHeaders(ForwardedState);            
                app.UseStatusCodePagesWithReExecute("/Home/NotFound", "?code={0}");
                app.UseExceptionHandler("/Error");
                app.UseSession();
                app.UseAuthentication();
                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                       name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}"
                     );
                    endpoints.MapAreaControllerRoute(
                     name: "Admin",
                     areaName: "Admin",
                     pattern: "{controller=Admin}/{action=Index}"
                    );
                    endpoints.MapAreaControllerRoute(
                      name: "AdminSignIn",
                      areaName: "AdminSignIn",
                      pattern: "{controller=AdminSign}/{action=Index}"
                     );
                    endpoints.MapAreaControllerRoute(
                       name: "AdminUser",
                       areaName: "AdminUser",
                       pattern: "{controller=AdminUsers}/{action=Index}/{id?}"
                     );
                    endpoints.MapAreaControllerRoute(
                      name: "AdminRoleList",
                      areaName: "AdminRoleList",
                      pattern: "{controller=AdminRolesList}/{action=Index}/{id?}"
                     );
                    endpoints.MapAreaControllerRoute(
                        name: "AdminCategory",
                        areaName: "AdminCategory",
                        pattern: "{controller=AdminCategoryCreate}/{action=Index}"
                     );
                    endpoints.MapControllerRoute(
                       name: "account",
                     pattern: "{controller=Account}/{action=SignIn}/{id?}"
                     );
                    endpoints.MapControllerRoute(
                        name: "registration",
                        pattern: "{controller=Registration}/{action=Register}"
                     );
                    endpoints.MapControllerRoute(
                        name: "forgotpassword",
                        pattern: "{controller=ForgotPassword}/{action=Index}"
                     );
                    endpoints.MapControllerRoute(
                        name: "resetpassword",
                        pattern: "{controller=ResetPassword}/{action=ResetPass}"
                     );
                    endpoints.MapControllerRoute(
                        name: "changepassword",
                        pattern: "{controller=ChangePassword}/{action=ChangePassworder}"
                    );
                    endpoints.MapRazorPages();
                });

                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
        }
        private StaticFileOptions CssAndContentFiles
        {
           
            get
            {
                return new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Contents")), RequestPath = "/Contents",
                    OnPrepareResponse = context => context.Context.Response.GetTypedHeaders().CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(365)
                    }
                    
                };
            }
        }
        private StaticFileOptions ImageFiles
        {
            get
            {
                return new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.GetFullPath(RootFolder.RootFolderWithSubFolder)),
                    RequestPath = "/Images"
                };
            }
        }
        private ForwardedHeadersOptions ForwardedState
        {
            get
            {
                return new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
                };
            }
        }
    }
}
