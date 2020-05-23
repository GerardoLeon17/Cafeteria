using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Product
    {
  
        public int Id { get; set; }
        [Display(Name = "Codigo Producto")]//Data annotation
        public string ProductCode { get; set; }
        [Display(Name = "Tipo")]//Data annotation
        public string Type { get; set; }
        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        public byte [] ImageUrl { get; set; }


    }

}
