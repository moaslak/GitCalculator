using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalculator
{
    internal class InputHandler
    {
        public double getDouble(string prompt)
        {
            double number = 0;
            do
            {
                Console.Write(prompt);
                Console.WriteLine();
            } while (!(double.TryParse(Console.ReadLine(), out number)));
            return number;
        }

        public int getInt(string prompt)
        {
            int number = 0;
            do
            {
                Console.Write(prompt);
                Console.WriteLine();
            } while (!(Int32.TryParse(Console.ReadLine(), out number)));
            return number;
        }
    }
}
