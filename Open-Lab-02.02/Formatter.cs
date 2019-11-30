using System;
using System.Globalization;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            foreach (var number in numbers);
            Console.Write(number.ToString("N2", CultureInfo.InvariantCulture) + " ");
        }
    }
}
