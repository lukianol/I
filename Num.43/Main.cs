using System.Collections.Generic;

namespace Num._43
{
    public static class Main
    {
        public static void ReverseWords(char[] sentence)
        {
            var lindex = 0;
            var length = sentence.Length;
            var rindex = length - 1;

            if (rindex <= 1) 
                return;

            ReverseChars(sentence, 0, rindex);

            for (rindex = 0; rindex <= length; rindex++)
            {
                if ((rindex != length) && (sentence[rindex] != ' ')) 
                    continue;

                ReverseChars(sentence, lindex, rindex - 1);
                lindex = rindex + 1;
            }
        }

        static void ReverseChars(IList<char> intext, int lindex, int rindex)
        {
            while (lindex < rindex)
            {
                var tempc = intext[lindex];
                intext[lindex++] = intext[rindex];
                intext[rindex--] = tempc;
            }
        }

    }
}


