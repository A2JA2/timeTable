using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFixed, numberInput;

            Console.Write("\n\n");
            Console.Write("Display the multiplication table:\n");
            Console.Write("------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number (Table to be calculated) : ");

            //input the number and convert to integer
            numberInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            for (numberFixed = 1; numberFixed <= 10; numberFixed++)//this is the loop, the loop ends when the fixed number is greater than 10.
            {
                Console.Write("{0} x {1} = {2} \n", numberInput, numberFixed, numberInput * numberFixed);
            }
            Console.ReadLine();
        }
    }
}
