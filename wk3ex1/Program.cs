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
        //method to convert to USD
        static double ConvertToUSD(double amount, string fromCurrency)
        {
            //return value
            double returnValue = 0;

            //loop to convert 
            if (fromCurrency == "EUR")
            {
                returnValue = amount * 0.9;
            }
            else if (fromCurrency == "JPY") 
            {
                returnValue = amount * 20;
            }

            return returnValue;
        }
        //method to convert to EUR
        static double ConvertToEUR(double amount, string fromCurrency)
        {
            double returnValue = 0;

            //loop to convert
            if (fromCurrency == "USD")
            {
                returnValue = amount * 0.9;
            }
            else if (fromCurrency == "JPY")
            {
                returnValue = amount * 25;
            }

            return returnValue;
        }
        //method to convert to JPY
        static double ConvertToJPY(double amount, string fromCurrency)
        {
            double returnValue = 0;

            //loop to convert
            if (fromCurrency == "USD")
            {
                returnValue = amount * 1.5;
            }
            else if (fromCurrency == "EUR")
            {
                returnValue = amount * 30;
            }

            return returnValue;
        }
        static void Main(string[] args)
        {
            //print out the converted currency
            Console.WriteLine("1 dollars equals to " + ConvertToEUR(1, "USD") + " EUR");
            Console.WriteLine("1 JPY equals to " + ConvertToEUR(1, "JPY") + " JPY");

            Console.ReadLine();
        }
    }
}
