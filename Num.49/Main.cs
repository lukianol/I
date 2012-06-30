using System.Linq;

namespace Num._49
{
    public static class Main
    {
        public static byte[] DoBackspace(byte[] charactes, int cursor)
        {
            if (cursor == 0)
                return charactes;

            var isKanji = ((charactes[cursor - 1] & 0x80) == 0x80);
            var bytesToBackspace = isKanji ? 2 : 1;

            return charactes.Take(cursor - bytesToBackspace).Union(charactes.Skip(cursor)).ToArray();
        }
    }
}
