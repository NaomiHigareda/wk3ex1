using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace wk3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter a currency
            Console.WriteLine("Enter an amount");
            //Convert currency to usd
            double amount = Convert.ToInt32(Console.ReadLine());
            //prompt user to enter a currency to convert in to usd
            Console.WriteLine("Enter an amount to convert into usd");
            string fromCurrency = Console.ReadLine();
            //prompt user to enter a currency to convert in to eur
            Console.WriteLine("Enter an amount to convert into eur");
            //convert currency to eur
            string toCurrency = Console.ReadLine();
            //prompt user to enter a currency to convert into JPY
            Console.WriteLine ("Enter a currency to convert into JPY");
            //convert currency to jpy
            string currency = Convert.ToString(Console.ReadLine());
            
            double convertedAmount = 0;
            {
                
            }

            


            
        }
    }
}
