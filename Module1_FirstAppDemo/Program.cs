using System;
using static System.Console; //you won't have to write console.xxxx

//Name: James Shoemaker
//Date: 03-17-2020
/*Program Description: This is our first program
 this written for module*/ 

namespace Module1_FirstAppDemo
{
    class Program
    {
        const double OVER_BUDGET_AMOUNT = 100.00;

        //Main is the starting point for an application
        static void Main(string[] args)
        {
            //declare and initialize variables
            int quantity = 0;
            double item_price = 0.0;
            double total_price = 0.0;

            
            const int RUNS = 3;

            double[] prices = new double[RUNS];
            int[] quantities = new int[RUNS];

            //Create a loop that prompts the user multiple times for price and quantity and store the information in parallel arrays
            for(int i = 0; i < RUNS; i++)
            {
                //prompt user for values and capture values in variables
                Console.Write("Enter the item price: ");
                item_price = Convert.ToDouble(ReadLine());
                prices[i] = item_price;

                Write("Enter the quantity purchased: ");
                quantity = Convert.ToInt32(ReadLine());
                quantities[i] = quantity;
            }
           

            //Calculate the total price
            total_price = CalculateTotal(prices, quantities, true);

            if(IsOverBudget(total_price) == true)
            {
                WriteLine("You are over Budget!");
            }
            else
            {
                WriteLine("Great job, you are staying under budget!");
            }
            
            WriteLine(" The total is {0}", total_price.ToString("C"));


        }
        //below you will see bool printValues = false. That is for having an optional value. Optional values must be at the end of the parameters list. 
        static double CalculateTotal(double[] amounts, int[] counts, bool printValues = false)
        {
            double total = 0;

            for(int counter = 0; counter < amounts.Length; counter++)
            {
                total = total + (amounts[counter] * counts[counter]);
            }

            if (printValues == true)
                PrintValues(amounts, counts);

            return total;
        }

        static void PrintValues(double[] amounts, int[] counts)
        {
            WriteLine("*************************Summary Information*************************");

            for (int i = 0; i < amounts.Length; i++)
            {
                WriteLine($"you entered item #{i + 1} price: {amounts[i].ToString("C")} and quantity: {counts[i]} ");
            }
        }

        static bool IsOverBudget(double amount)
        {
            if (amount > OVER_BUDGET_AMOUNT)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
