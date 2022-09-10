using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abc.MvcWebUI.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Abc.MvcWebUI.Models
{
    public class OrderDetailsModel
    {
       
        [DisplayName("Sipariş ID")]
        public int OrderId { get; set; }
       
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        
        [DisplayName("Sipariş Numarası")]
        public string OrderNumber { get; set; }
      
        [DisplayName("Genel Toplam")]
        public double Total { get; set; }
        
        [DisplayName("Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }
   
        [DisplayName("Sipariş Durumu")]
        public EnumOrderState OrderState { get; set; }

 
        [DisplayName("Adres Başlığı")]
        public string AdresBasligi { get; set; }
     
        [DisplayName("Adres")]
        public string Adres { get; set; }
     
        [DisplayName("Şehir")]
        public string Sehir { get; set; }
     
        [DisplayName("Semt")]
        public string Semt { get; set; }
  
        [DisplayName("Mahale")]
        public string Mahalle { get; set; }
       
        [DisplayName("Posta Kodu")]
        public string PostaKodu { get; set; }

        public virtual List<OrderLineModel> Orderlines { get; set; }
    }

    public class OrderLineModel
    {
        
        [DisplayName("Ürün ID")]
        public int ProductId { get; set; }
 
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }
   
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
      
        [DisplayName("Ürün Miktarı")]
        public int Quantity { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
    }
}