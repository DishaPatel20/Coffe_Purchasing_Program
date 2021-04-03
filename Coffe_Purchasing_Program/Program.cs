using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Purchasing_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // To store cost of the coffee:-
            int TotalCoffeCost = 0;

            // HERE IS A LABEL :-
        Start:
            Console.WriteLine("Please Select Your Coffee Size:- 1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your Choice is Invalid", UserChoice);
                    goto Start;
            }

        Decide:
            Console.WriteLine("Do You Want to Buy Another Coffee - YES or NO ?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice is Invalid. Please Try Again...", UserDecision);
                    goto Decide;
            }

            Console.WriteLine("ThankYou for Shopping WithUs");
            Console.WriteLine("Bill Amount = {0}$", TotalCoffeCost);
            Console.ReadLine();
        }
    }
}
