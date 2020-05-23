using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Codigo orden")]//Data annotation
        public string OrderCode { get; set; }
        [Display(Name = "Nombre del cliente")]//Data annotation
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Total")]
        public decimal Total { get; set; }
        [Display(Name = "Estatus")]
        public string Status { get; set; }
        [Display(Name = "Id del producto")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}