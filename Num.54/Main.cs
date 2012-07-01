using System;
using System.IO;

namespace Num._54
{
    public static class Main
    {
        public static void PrintInSpiralOder<T>(T[,] array, TextWriter writer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (writer == null) throw new ArgumentNullException("writer");
            PrintTopRight(array, writer, 0, 0, array.GetLength(1) - 1, array.GetLength(0) - 1);
        }

        private static void PrintTopRight<T>(T[,] array, TextWriter writer, int x1, int y1, int x2, int y2)
        {
            for(var i=x1; i <= x2; i++)
            {
                writer.Write(array[y1,i]);
            }

            for (var i = y1 + 1; i <= y2; i++)
            {
                writer.Write(array[i,x2]);
            }

            if (x2 - x1 > 0)
            {
                PrintBottomLeft(array, writer, x1, y1 + 1, x2 - 1, y2);
            }
        }

        private static void PrintBottomLeft<T>(T[,] array, TextWriter writer, int x1, int y1, int x2, int y2)
        {
            for (var i = x2; i >= x1; i--)
            {
                writer.Write(array[y2,i]);
            }

            for (var j = y2 - 1; j >= y1; j--)
            {
                writer.Write(array[j,x1]);
            }

            if (x2 - x1 > 0)
            {
                PrintTopRight(array, writer, x1 + 1, y1, x2, y2 - 1);
            }
        }
    }
}
