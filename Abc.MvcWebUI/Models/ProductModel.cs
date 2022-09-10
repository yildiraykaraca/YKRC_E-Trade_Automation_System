using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ProductModel
    {
       
        [DisplayName("Ürün ID")]
        public int Id { get; set; }
       
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
     
        [DisplayName("Ürün Stok Adedi")]
        public int Stock { get; set; }
   
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
     
        [DisplayName("Ürün Kategorisi")]
        public int CategoryId { get; set; }
    }
}