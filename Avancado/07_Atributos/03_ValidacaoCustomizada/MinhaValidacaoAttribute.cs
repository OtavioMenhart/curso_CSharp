using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada
{
    class MinhaValidacaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (((string)value).Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
