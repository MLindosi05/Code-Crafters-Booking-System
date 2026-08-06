using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class ValidationHelper
    {
        public static bool IsEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

        public static bool IsNumber(string value)
        {
            return decimal.TryParse(value, out _);
        }

        public static bool IsEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsName(string text)
        {
            return text.All(c => char.IsLetter(c) || c == ' ');
        }

        public static bool IsEmpty(params string[] values)
        {
            return values.Any(string.IsNullOrWhiteSpace);
        }
    }
}