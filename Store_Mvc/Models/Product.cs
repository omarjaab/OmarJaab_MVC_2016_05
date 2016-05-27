using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Store_Mvc.Attribute;

namespace Store_Mvc.Models
{
    public class Product
    {
        //omarjaab 
        [Required]
        public int Id { get; set; }
        [Required,MaxLength(20)]
        public string Name { get; set; }   
        [MaxLength(30)] 
        public string ProductText { get; set; }
       [ProductNumberCheck]
        public string ProductNumber { get; set; }
        [Range(1,10000)]
        public double Price { get; set; }
        [MaxLength(20)]
        public string ProductInStock { get; set; }
        public Store Store { get; set; }    


    }
}