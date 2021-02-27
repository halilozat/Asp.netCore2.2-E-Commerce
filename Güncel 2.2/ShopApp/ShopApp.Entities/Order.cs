using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopApp.Entities
{
    public class Order
    {
        // stripe
        // IYZICO
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }

        public EnumOrderState OrderState { get; set; }
        public EnumPaymentTypes PaymentTypes { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OrderNote { get; set; }

        public string PaymentId { get; set; }
        public string PaymentToken { get; set; }
        public string ConversationId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }

    public enum EnumOrderState //sipariş durumu
    {
        [Description("Hazırlanıyor")]
        waiting = 0, //beklemede veya hazırlanıyor.
        [Description("Yolda")]
        Unpaid = 1, //ödenmemiş veya yolda
        [Description("Tamamlandı!")]
        Completed = 2 //ödenmiş
    }

    public enum EnumPaymentTypes
    {
        [Description("Kredi Kartı (Yapım Aşamasında)")]
        CreditCart = 0,
        [Description("Kapıda Ödeme")]
        KapidaOdeme = 1,
        [Description("Kapıda Kredi Kartı")]
        KapidaKrediKarti = 2
    }
}
