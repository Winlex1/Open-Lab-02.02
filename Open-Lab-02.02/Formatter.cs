using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            foreach(double value in numbers)
            {
                Console.Write(Math.Round(value, 2) + " ");
            }
        }
    }
}
