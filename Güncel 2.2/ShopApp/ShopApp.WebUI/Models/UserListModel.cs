using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class UserListModel: IdentityUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public List<UserListModel> UserList { get; set; }

    }
}
