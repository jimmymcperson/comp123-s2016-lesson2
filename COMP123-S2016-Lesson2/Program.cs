﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Jonathan Hao
 * Date: May 17, 2016
 * Date Modified: May 17, 2016
 * Description: Advanced Methods Demo for Lesson 2
 * Version: 0.0.3 - Added addXandY method
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
    }
}
