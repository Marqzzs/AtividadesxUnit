using System;

namespace Gmail
{
    public static class Email
    {
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return email.Contains("@") && email.Contains(".");
        }
    }
}
