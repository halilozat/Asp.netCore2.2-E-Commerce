using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class OrderModel
    {
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }
        [Display(Name = "E-posta")]
        public string Email { get; set; }
        [Display(Name = "Kart İsmi")]
        public string CardName { get; set; }
        [Display(Name = "Kart Numarası")]
        public string CardNumber { get; set; }
        [Display(Name = "Ay")]
        public string ExpirationMonth { get; set; }
        [Display(Name = "Yıl")]
        public string ExpirationYear { get; set; }
        [Display(Name = "Cvv")]
        public string Cvv { get; set; }
        [Display(Name = "Sipariş Notu")]
        public string OrderNote { get; set; }
        public CartModel CartModel { get; set; }

        public EnumPaymentTypes PaymentTypes { get; set; }
    }
}
