namespace Sum2BigNums
{
    public class BigNumberAdder
    {
        public string Sum(string stn1, string stn2)
        {
            
            // Remove leading zeros 
            string number1 = stn1.TrimStart('0');
            string number2 = stn2.TrimStart('0');


            //if (string.IsNullOrEmpty(number1)) number1 = "0";
            //if (string.IsNullOrEmpty(number2)) number2 = "0";

            if (string.IsNullOrEmpty(number1) && string.IsNullOrEmpty(number2)) return "0";

            if (string.IsNullOrEmpty(number1)) return number2;

            if (string.IsNullOrEmpty(number2)) return number1;

            int len1 = number1.Length;
            int len2 = number2.Length;
            int maxLen = Math.Max(len1, len2);

            string result = "";
            int carry = 0;

            // Add digits from right to left
            for (int i = 0; i < maxLen; ++i)
            {
                int digit1 = (len1 - 1 - i >= 0) ? number1[len1 - 1 - i] - '0' : 0;
                int digit2 = (len2 - 1 - i >= 0) ? number2[len2 - 1 - i] - '0' : 0;

                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result = (sum % 10) + result;

                // Logging
                Console.WriteLine($"Digit1: {digit1}, Digit2: {digit2}, Sum: {sum % 10}, Carry: {carry}");
            }

            if (carry > 0)
            {
                result = carry + result;
            }

            
            //if (string.IsNullOrEmpty(result))
            //{
            //    result = "0";
            //}


            return result.TrimStart('0').Length == 0 ? "0" : result.TrimStart('0');
        }
    }

}
