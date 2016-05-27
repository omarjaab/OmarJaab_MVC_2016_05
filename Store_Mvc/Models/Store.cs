using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store_Mvc.Models
{
    public class Store
    {
        //omarjaab
        [Required]
        public int Id { get; set; }
        [Required,MaxLength(20)]
        public string Name { get; set; }
        [Required,MaxLength(20)]
        public string Address { get; set; }
        public IList<Product> Products { get; set; }
    }
}