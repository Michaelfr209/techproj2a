using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelRivera_TechProj2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value between 1 and 20 to execute an iterative statement: ");

            try
            {
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);






                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("You have entered " + value_of_input + ". This is the current integer value in the FOR loop - " + value_of_input.ToString() + " times.");
                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }





            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }


        }
    }
}


