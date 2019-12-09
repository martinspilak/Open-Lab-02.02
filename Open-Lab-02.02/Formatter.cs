using System;
using System.Globalization;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i].ToString("N2", CultureInfo.InvariantCulture));
                
                if (i < numbers.Length - 1)
                    Console.Write(" ");
            }
            
        }
    }
}
