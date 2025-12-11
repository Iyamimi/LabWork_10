using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabLibrary
{
    public static class Password
    {
        public static bool PasswordValidation(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length >= 8 && password.Any(char.IsDigit) && Regex.IsMatch(password, "[A-Za-z]"))
                return true;
            return false;
        }
    }
}
