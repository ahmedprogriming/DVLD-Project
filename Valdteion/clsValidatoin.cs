using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valdteion
{
    public class clsValidatoin
    {
        public static bool ValidateEmail(string email)
        { var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var redex=new Regex(pattern);
            return redex.IsMatch(email);
        }
    }
}
