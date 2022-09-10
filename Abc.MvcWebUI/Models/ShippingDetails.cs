using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ShippingDetails
    {
   
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
      
        [Required(ErrorMessage = "Lütfen adres tanımını giriniz.")]

        [DisplayName("Adres Başlığı:")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Lütfen bir adres giriniz.")]
        [DisplayName("Adres")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen şehir giriniz.")]
        [DisplayName("Şehir")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen semt giriniz.")]
        [DisplayName("Semt")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lütfen mahalle giriniz.")]
        [DisplayName("Mahalle")]
        public string Mahalle { get; set; }
        [DisplayName("Posta Kodu")]
        public string PostaKodu { get; set; }
    }
}