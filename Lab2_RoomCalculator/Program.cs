//Mina Stanton
//January 21, 2020
//Program description: This program will take in the dimensions of a room and calculate the area, perimeter and volume. 
/*Explain in 3 steps:
 * 1. How to get input from the user: First, I created variables to hold the input. Then I printed to the screen asking the user
 * to input the values of each variable. Then I read in each input and stored it into the correct variable.
 * 2. I created variables to hold the value after calculations. The variables area, perimeter and volume. Then utilizing formula's
 * I calculate each one and store the value in the appropriate variable.
 * 3. Using a WriteLine statement I wrote the text for each calculated variable then added the value of that variable to the string then 
 * I added a new line in order to display them on individual lines. 
 */

using System;

namespace Lab2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, area, perimeter, volume;

            string userContinues = "y";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Hello! Welcome to the Room Calculator.");
            Console.WriteLine();//adding a line for readability

            //utilizing a while loop to continue calculating rooms until the user is ready to stop
            while (userContinues == "y")
            {
                //input
                Console.Write("Please enter the Room's Length in inches: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Please enter the Room's Width in inches: ");
                width = double.Parse(Console.ReadLine());

                Console.Write("Please enter the Room's height in inches: ");
                height = double.Parse(Console.ReadLine());

                //processing
                area = Math.Round((length * width), 2);
                perimeter = Math.Round((2 * (length + width)), 2);
                volume = Math.Round((length * width * height), 2);

                //output
                Console.WriteLine();//adding a line for readability
                Console.WriteLine("The Area is: " + area + " inches Squared" + Environment.NewLine + "The Perimeter is: " + perimeter + " inches Squared" + Environment.NewLine + "The Volume is: " + volume + " cubic units");
                Console.WriteLine();//adding a line for readability

                Console.Write("Would you like to calculate another room? Type 'y' if you do: ");
                userContinues = Console.ReadLine().ToLower();
                Console.WriteLine();//adding a line for readability
            }

            Console.WriteLine();//adding a line for readability
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Otay, thanks for using Room Calculator, bye!");
        }
    }
}