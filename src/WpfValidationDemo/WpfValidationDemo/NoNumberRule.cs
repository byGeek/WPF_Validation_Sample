using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfValidationDemo
{
    public class NoNumberRule : ValidationRule
    {
        public NoNumberRule()
        {

        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string username = string.Empty;

            try
            {
                username = value.ToString();
                var arr = username.ToCharArray();
                foreach(var ch in arr)
                {
                    if(ch > '0' && ch < '9')
                    {
                        return new ValidationResult(false, "Can not accept number!");
                    }
                }
            }
            catch(Exception e)
            {
                return new ValidationResult(false, e.Message);
            }

            return ValidationResult.ValidResult;
        }
    }
}
