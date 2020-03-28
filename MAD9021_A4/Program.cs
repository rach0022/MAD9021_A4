/*************************
 *
 *  @description The main class that will run test use cases for my Dice and DiceDLX classes
 *
 *  @author Ravi Chandra Rachamalla rach0022@algonquinlive.com
 *
 *  @version Mar 28, 2020
 *
 ***********************/

using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD9021_A4
{      

    class Program
    {
        static void Main(string[] args)
        {

            //Dice d1 = new Dice();

            //for(int i = 0; i < 100000; i++)
            //{
            //    Console.Write("Dice Roll #" + i + ": ");
            //    d1.Roll();
            //    d1.Draw();
            //}

            var dX1 = new DiceDLX(3);
            

            for (int i = 0; i < 6000000; i++)
            {
                dX1.Roll();
            }

            //get the array of roll statistics
            uint[] rolledNumbers = dX1.GetStatistics();

            // output

            Console.WriteLine("Dice Statistics:\n\n");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"\t   {i + 1}\t");
            }

            string dashes = new string('-', 100);

            Console.WriteLine();
            Console.WriteLine(dashes);

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write($"\t{rolledNumbers[i]}\t");
            //}
            foreach (int num in rolledNumbers)
            {
                Console.Write($"\t{num}\t");
            }

            Console.WriteLine("\n");

            //dX1.Draw();

            var testDice = new Dice();
            var testDelux = new DiceDLX();

            testDice.Roll();
            testDelux.Roll();

            testDice.Draw();
            testDelux.Draw();


            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();

        }
    }
}

/* Reflection Comments:
 * 1. This code seems very similar to the java code, in some ways csharp is more verbose and in some ways java is more verbose
 * 
 * 2. In c# I like how functionally similar it is to C++ while also having its own advantages
 * 
 * 3. I dont like all the capitals for starting the function names, it seems small but I like writing console.writeLine vs Console.WriteLine
 * 
 * 4. The Dice classes we created are useful if we were to expand our code to make some dice related games, as now we can resue that code in order to avoid rewriting it each time.
 * 
 * 5. Looking forward to how the rest of the course will progress. 
 * 
 */