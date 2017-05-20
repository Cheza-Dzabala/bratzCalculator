using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bratzTeamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first digit. ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input second digit. ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Method: ");
            Console.WriteLine("1. Subtract");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply");


            int selection = int.Parse(Console.ReadLine());

            switch(selection)
            {
                case 1:
                    Console.WriteLine("Subtraction");
                    break;
                case 2:
                    Console.WriteLine("Addition");
                    break;
                case 3:
                    Console.WriteLine("Division");
                    break;
                case 4:
                    Console.WriteLine("Multiplication");
                    break;
            }
        }
    }
}
