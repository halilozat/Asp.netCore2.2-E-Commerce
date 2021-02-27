using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            var adminusername = configuration["Data:AdminUser:username"];
            var adminemail = configuration["Data:AdminUser:email"];
            var adminpassword = configuration["Data:AdminUser:password"];
            var adminrole = configuration["Data:AdminUser:role"];

            var kasiyerusername = configuration["Data:KasiyerUser:username"];
            var kasiyeremail = configuration["Data:KasiyerUser:email"];
            var kasiyerpassword = configuration["Data:KasiyerUser:password"];
            var kasiyerrole = configuration["Data:KasiyerUser:role"];

            var kuryeusername = configuration["Data:KuryeUser:username"];
            var kuryeemail = configuration["Data:KuryeUser:email"];
            var kuryepassword = configuration["Data:KuryeUser:password"];
            var kuryerole = configuration["Data:KuryeUser:role"];

            if (await userManager.FindByNameAsync(adminusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminrole));
                var adminuser = new ApplicationUser()
                {
                    UserName = adminusername,
                    Email = adminemail,
                    FullName = "Admin User",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminuser, adminpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminuser, adminrole);
                }
            }
            if (await userManager.FindByNameAsync(kasiyerusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(kasiyerrole));
                var kasiyeruser = new ApplicationUser()
                {
                    UserName = kasiyerusername,
                    Email = kasiyeremail,
                    FullName = "Kasiyer User",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(kasiyeruser, kasiyerpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(kasiyeruser, kasiyerrole);
                }
            }
            if (await userManager.FindByNameAsync(kuryeusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(kuryerole));
                var kuryeuser = new ApplicationUser()
                {
                    UserName = kuryeusername,
                    Email = kuryeemail,
                    FullName = "Kurye User",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(kuryeuser, kuryepassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(kuryeuser, kuryerole);
                }
            }
        }
    }
}
