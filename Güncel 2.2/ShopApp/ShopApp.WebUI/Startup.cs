using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Identity;
using ShopApp.WebUI.Middlewares;

namespace ShopApp.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // password

                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

                options.Lockout.MaxFailedAccessAttempts = 25;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = false;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ShopApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };

            });

            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
            services.AddScoped<ICartDal, EfCoreCartDal>();
            services.AddScoped<IOrderDal, EfCoreOrderDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();


            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed();
            }
            app.UseStaticFiles();
            //app.CustomStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {



                routes.MapRoute(
                 name: "adminuseredit",
                 template: "admin/user/{id?}",
                 defaults: new { controller = "Admin", action = "UserEdit" }
                );

                //routes.MapRoute(
                // name: "search",
                // template: "shop/search/{?q}",
                // defaults: new { controller = "Shop", action = "Search" }
                //);


                routes.MapRoute(
                 name: "adminusers",
                 template: "admin/user/list",
                 defaults: new { controller = "Admin", action = "UserList" }
                );

                routes.MapRoute(
                 name: "adminroleedit",
                 template: "admin/role/{id?}",
                 defaults: new { controller = "Admin", action = "RoleEdit" }
                );


                routes.MapRoute(
                 name: "adminroles",
                 template: "admin/role/list",
                 defaults: new { controller = "Admin", action = "RoleList" }
                );

                routes.MapRoute(
                 name: "adminrolecreate",
                 template: "admin/role/create",
                 defaults: new { controller = "Admin", action = "RoleCreate" }
                );

                routes.MapRoute("areaRoute", "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

                routes.MapRoute(
                 name: "adminProducts",
                 template: "admin/products",
                 defaults: new { controller = "Admin", action = "ProductList" }
                );

                routes.MapRoute(
                    name: "adminProducts",
                    template: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "EditProduct" }
                );
                routes.MapRoute(
                 name: "adminCustoemers",
                 template: "admin/customers",
                 defaults: new { controller = "Admin", action = "CustomerList" }
                );

                routes.MapRoute(
                    name: "adminCustoemers",
                    template: "admin/customers/{id?}",
                    defaults: new { controller = "Admin", action = "EditCustomer" }
                );

                routes.MapRoute(
                  name: "cart",
                  template: "cart",
                  defaults: new { controller = "Cart", action = "Index" }
                );

                routes.MapRoute(
                  name: "orders",
                  template: "orders",
                  defaults: new { controller = "Cart", action = "GetOrders" }
                );

                routes.MapRoute(
                  name: "checkout",
                  template: "checkout",
                  defaults: new { controller = "Cart", action = "Checkout" }
                );

                routes.MapRoute(
                  name: "products",
                  template: "products/{category?}",
                  defaults: new { controller = "Shop", action = "List" }
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );

                

            });
            

             SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();

        }
    }
}
