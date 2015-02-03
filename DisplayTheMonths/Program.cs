using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTheMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 12; i++)
            {
                //here is a fun comment
                var monthName = GetMonthName(i);
                Console.WriteLine(monthName + " words are hard.");
            }
            Console.ReadLine();
        }

        private static string GetMonthName(int month)
        {
            
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "Not found";
            }
        }
    }
}
