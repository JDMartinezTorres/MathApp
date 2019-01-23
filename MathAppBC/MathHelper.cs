using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAppBC
{
    public class MathHelper
    {
        double z;
        bool c = true;
        double x;
        double y;
        public void  askUserForNumbers()
        {
            Console.WriteLine("Please enter the first number.");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            y = double.Parse(Console.ReadLine());
            
        }
        public double CalculationHelper()
        {

                while (c == true)
                {
                    Console.WriteLine("Please type +, -, *, /, or % for mathematical assistance or type anything else to exit.");
                    string starter = (Console.ReadLine());
                    if (starter == "+")
                    {
                        askUserForNumbers();
                         z=x + y;
                         Console.WriteLine($"The answer is {z:n}");
                       return CalculationHelper();
                    }
                    if (starter == "-")
                    {
                        askUserForNumbers();
                        z= x - y;
                        Console.WriteLine($"The answer is {z:n}");
                          return CalculationHelper();
                    }
                    if (starter == "*")
                    {
                        askUserForNumbers();
                        z= x * y;
                         Console.WriteLine($"The answer is {z:n}");
                         return CalculationHelper();
                    }
                    if (starter == "/")
                    {
                        askUserForNumbers();
                        if (y == 0)
                        {
                            Console.WriteLine("Division by zero is invalid. Please enter in a valid number 2.");
                            y = double.Parse(Console.ReadLine());
                             z= x / y;
                             Console.WriteLine($"The answer is {z:n}");
                             return CalculationHelper();
                        }
                        else
                        {
                            z= x / y;
                             Console.WriteLine($"The answer is {z:n}");
                             return CalculationHelper();
                        }
                    }
                    if (starter == "%")
                    {
                        askUserForNumbers();
                        z= x % y;
                         Console.WriteLine($"The answer is {z:n}");
                         return CalculationHelper();
                    }
                    if (starter != "+" || starter != "-" || starter != "*" || starter != "/" || starter != "%" )
                    {
                    Console.WriteLine("Thanks for stopping by!");
                    c = false;
                    }
                  
            }
            return z;
        }
    }
}
