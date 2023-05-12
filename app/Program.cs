using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program // Switch = Switch statement an alternative to many statements Program.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter: Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday");
            string a = Console.ReadLine();
            switch (a)
            {
                case "Monday":
                    Console.WriteLine("Monday:");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday:");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday:");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday:");
                    break;
                case "Friday":
                    Console.WriteLine("Friday:");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday:");
                    break;
                case "Sunday":
                    Console.WriteLine("Sunday:");
                    break;
                default:
                    Console.WriteLine("Sorry : Not too bad : Ref:youtube ! ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
