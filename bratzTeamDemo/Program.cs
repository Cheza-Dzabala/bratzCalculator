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
            Console.WriteLine("Welcome to Bratz Calculator");
            string UserChoice = string.Empty;
            do {
                Console.WriteLine("Please input first digit.. ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please input second digit.. ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select Method: ");
                Console.WriteLine("1. Subtract");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Divide");
                Console.WriteLine("4. Multiply");


                int selection = int.Parse(Console.ReadLine());


                switch (selection)
                    {
                    case 1:
                        Console.WriteLine("\nYou selected the Subtract Method");
                        Console.WriteLine($"{num1} - {num2} = {calculatorClass.subtraction(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine("\nYou selected the Add Method");
                        Console.WriteLine($"{num1} + {num2} = {calculatorClass.Add(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine("Division");
                        break;
                    case 4:
                        Console.WriteLine("\nYou selected the Multiply Method");
                        Console.WriteLine($"{num1} * {num2} = {calculatorClass.Multiply(num1, num2)}");
                        break;
                    }
                do
                    {
                    Console.WriteLine("Would you like to calculate some more?");

                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                        {
                        Console.WriteLine("Invalid Choice, please say Yes or No");
                        }
                    } while (UserChoice != "YES" && UserChoice != "NO");
                } while (UserChoice == "YES");
            } 
    }
}
