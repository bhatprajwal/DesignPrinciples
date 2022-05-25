using SRP.Models;
using System.Text.RegularExpressions;

namespace SRP.Service
{
    public class ValidateUser
    {
        private const string _regExpressionEmail = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
       
        public static bool IsBasicValidationChecked(User user)
        {
            if(string.IsNullOrWhiteSpace(user.FirstName))
                return false;
            if(string.IsNullOrWhiteSpace(user.LastName))
                return false;
            if(string.IsNullOrWhiteSpace(user.Email))
                return false;

            return true;
        }

        public static bool IsValidEmail(string email)
        {
            Regex regex = new Regex(_regExpressionEmail, RegexOptions.CultureInvariant | RegexOptions.Singleline);
            return regex.IsMatch(email);
        }
    }
}