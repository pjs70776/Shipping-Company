using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            //Begin program
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.ReadLine();

            //User input for weight
            Console.WriteLine("Enter the package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            //Weight determination
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                //Remaining user input
                Console.WriteLine("Enter the package width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the package length");
                int length = Convert.ToInt32(Console.ReadLine());

                //Dimentions determination
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("Your package meets our specifications to be shipped.");
                    //Package calculation
                    int shippingCostNoWeight = (width * height * length);
                    int ShippingCostPlusWeight = (shippingCostNoWeight * weight);
                    int totalShippingCost = (ShippingCostPlusWeight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + totalShippingCost + " Thank you!");
                    Console.ReadLine();
                }
                Console.ReadLine();

                
            }
            
           

        }
    }
}
