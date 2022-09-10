using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abc.MvcWebUI.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Abc.MvcWebUI.Models
{
    public class UserOrderModel
    {
        [Required]
        [DisplayName("Sipariş ID")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Sipariş Numarası")]
        public string OrderNumber { get; set; }
        [Required]
        [DisplayName("Genel Toplam")]
        public double Total { get; set; }
        [Required]
        [DisplayName("Sipariş Durumu")]
        public EnumOrderState OrderState { get; set; }
        [Required]
        [DisplayName("Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }
    }
}