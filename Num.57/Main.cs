namespace Num._57
{
    public static class Main
    {
        public static string ToUppercase(string input)
        {
            var charArray = input.ToCharArray();

            for (var i = 0; i < charArray.Length; i++)
            {
                var c = charArray[i];
                if ((c >= 'a') && (c <= 'z'))
                {
                    charArray[i] = (char)(c - Offset);
                }

            }

            return new string(charArray);
        }

        private const int Offset = 'a' - 'A';
    }
}
