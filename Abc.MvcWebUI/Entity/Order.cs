using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Order
    {

        [DisplayName("Sipariş ID")]
        public int Id { get; set; }
        [DisplayName("Sipariş Numarası")]
        public string OrderNumber { get; set; }
        [DisplayName("Genel Toplam")]
        public double Total { get; set; }
        [DisplayName("Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Sipariş Durumu")]
        public EnumOrderState OrderState { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
        [DisplayName("Adres Başlığı")]
        public string AdresBasligi { get; set; }
        [DisplayName("Adres")]
        public string Adres { get; set; }
        [DisplayName("Şehir")]
        public string Sehir { get; set; }
        [DisplayName("Semt")]
        public string Semt { get; set; }
        [DisplayName("Mahalle")]
        public string Mahalle { get; set; }
        [DisplayName("Posta Kodu")]
        public string PostaKodu { get; set; }
        [DisplayName("Sipariş Hatları")]
        public virtual List<OrderLine> Orderlines{ get; set; }
    }

    public class OrderLine
    {
        [DisplayName("Sipariş Hat ID")]
        public int Id { get; set; }
        [DisplayName("Sipariş ID")]
        public int OrderId { get; set; }
        [DisplayName("Sipariş")]
        public virtual Order Order { get; set; }
        [DisplayName("Sipariş Miktarı")]
        public int Quantity { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Ürün ID")]
        public int ProductId { get; set; }
        [DisplayName("Ürün")]
        public virtual Product Product { get; set; }
    }
}