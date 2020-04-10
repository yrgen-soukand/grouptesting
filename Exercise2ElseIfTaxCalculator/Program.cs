using System;

namespace Exercise2ElseIfTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your balance: ");
            double userInput = double.Parse(Console.ReadLine());
            Console.WriteLine("Your balance after tax is: " +TaxCalculator(userInput));
        }

        public static double TaxCalculator(double userInput)
        {
            if (userInput <= 500)
            {
                double afterTax = userInput;
                return afterTax;
            }

            else if (userInput <= 800)//ei pea lisama kuni 500 sest see kontrollitakse eelmise lausega
            {
                double taxRate = 0.22;
                double afterTax = (userInput +  userInput * taxRate);
                return afterTax;
            }

            else
            {
                double taxRate = 0.28;
                double afterTax = (userInput+ userInput * taxRate);
                return afterTax;
            }
                
        }
    }
}
