using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class OrderStateModel
    {
        [Display(Name = "Ödeme Durumu")]
        public EnumOrderState orderState { get; set; }

        //public List<Order> Orders { get; set; }
    }

    
}
