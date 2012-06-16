namespace Num._47
{
    public static class Main
    {
        /// <summary>
        /// This method uses shift and subtraction underhood. 
        /// It works only with integers because there is no other simple way as '*' for floating points
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int MultiplyBy7(int number)
        {
            return (number << 3) - number;
        }
    }
}
