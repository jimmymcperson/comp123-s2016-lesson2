using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Jonathan Hao
 * Date: May 17, 2016
 * Date Modified: May 17, 2016
 * Description: Advanced Methods Demo for Lesson 2
 * Version: 0.0.5 - Added readUntilEnd
 */
namespace COMP123_S2016_Lesson2
{
    /**
     * Main driver class for Lesson 2
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * Main method for our drive class
         * 
         * @constructor Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;

            Console.WriteLine(addXandY(x, y));
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);

            Console.WriteLine(x);
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            readUntilEnd();
        }
        /**
         * A simple method to add two values
         * 
         * @method addXandY
         * @param {int} firstNumber
         * @param {int} secondNumber
         */
        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }

        /**
         * Simple method to demonstrate pass by reference with ref keyword
         * 
         * @method addytoX
         * @param {ref int} X
         * @param {ref int} Y
         */

        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;

            return X;
        }
        public static string[] readUntilEnd()
        {
            string[] inputs = new string[100];
            int i = 0;



            do
            {
                Console.WriteLine("Enter a value (type \"end\" to stop)");
                inputs[i] = Console.ReadLine();
                if (inputs[i] == "end")
                {
                    i = -1;
                }
                else
                {
                    i++;
                }
            } while (i != -1);

            return inputs;
        }
    }
}
