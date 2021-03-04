using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Markup;

namespace Utility.Helpers
{
    public  class ListCountAttribute:ValidationAttribute
    {
       
        public override bool IsValid(object value)
        {
            dynamic d = value; 

            return d != null && d.Count > 0;
        }
    }
}
