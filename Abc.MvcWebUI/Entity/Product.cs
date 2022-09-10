using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklama")]
        public string Description { get; set; }
        [DisplayName("Ürün Fiyat")]
        public double Price { get; set; }
        [DisplayName("Ürün Stoğu")]
        public int Stock { get; set; }
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
        [DisplayName("Anasayfada Listele")]
        public bool IsHome { get; set; }
        [DisplayName("Onay Durumu")]
        public bool IsApproved { get; set; }
        [DisplayName("Ürün Kategorisi")]
        public int CategoryId { get; set; }
        [DisplayName("Ürün Kategorisi")]
        public Category Category { get; set; }
    }
}