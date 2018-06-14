
using System.Text.RegularExpressions;


namespace ETS
{
    public static class Validation
    {
        public static bool IsEmptyString(string input)
        {
            return (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));
        }

        public static bool IsLettersOnly(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }


        public static bool IsValidPhoneNumber(string input)
        {
            int errorCounter = Regex.Matches(input, @"[a-zA-Z]").Count;
            if (errorCounter > 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsCorrectEmail(string input)
        {
            if (Regex.Match(input, @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                   + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
        [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
        [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                   + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$").Success)
            {
                return true;
            }
            return false;
        }
    }
}
