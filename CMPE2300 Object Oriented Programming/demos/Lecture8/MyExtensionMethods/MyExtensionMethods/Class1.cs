namespace MyExtensionMethods
{
    public static class MyExtension
    {
        public static int ReverseDigits(this int value)
        {
            char[] digits = value.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            int.TryParse(newDigits, out int val);

            return val;
        }
    }
}
