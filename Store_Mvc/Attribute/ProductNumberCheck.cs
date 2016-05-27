using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store_Mvc.Attribute
{
    //omarJaab
    public class ProductNumberCheck:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value==null)
            {
                return false;
            }
            var ToCheck = value.ToString().ToCharArray();
            return ToCheck[0] == 'p' && ToCheck[1] == '-';
        }

        public override string FormatErrorMessage(string name)
        {
            return name + "productName starts with P - (number)";
        }
    }
}