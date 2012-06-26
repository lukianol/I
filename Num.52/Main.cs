using System.Linq;
using System.Text;

namespace Num._52
{
    public static class Main
    {
        public static string RemoveCharacters(/*S1*/string characters, /*S2*/string value)
        {
            var uniqueChars = _60.Main.CompressArray(characters.ToCharArray());
            var builder = new StringBuilder(value.Length);
            foreach (var @char in value)
            {
                var isInUniqueChars = uniqueChars.Any(uniqueChar => uniqueChar == @char);
                if (isInUniqueChars) continue;
                builder.Append(@char);
            }

            return builder.ToString();

        }
    }
}
