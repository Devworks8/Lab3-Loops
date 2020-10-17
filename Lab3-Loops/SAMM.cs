// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab3 - Loops
//  Version: 1.0
//
//  Description: Perform a number of opertions using loops.
//
// SAMM.cs
//
//  Author:
//       Christian Lachapelle <lachapellec@gmail.com>
//
//  Copyright (c) 2020 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace Lab3Loops
{
    public static class SAMM
    {
        // Calculate the sum.
        private static decimal Sum(decimal[] nums)
        {
            decimal sum = 0;

            foreach (decimal num in nums)
            {
                sum += num;
            }
            return sum;
        }

        // Calculate the average.
        private static decimal Avg(decimal[] nums)
        {
            return Sum(nums) / nums.Length;
        }

        // Calculate the minimum.
        private static decimal Min(decimal[] nums)
        {
            decimal min = nums[0];

            foreach (decimal num in nums)
            {
                min = num < min ? num : min;
            }
            return min;
        }

        // Calculate the maximum.
        private static decimal Max(decimal[] nums)
        {
            decimal max = nums[0];

            foreach (decimal num in nums)
            {
                max = num > max ? num : max;
            }
            return max;
        }

        // Collect values from the user and display the results.
        public static void Calculate(ushort iterations)
        {
            decimal[] entries = new decimal[iterations];

            // Capture cursor position
            var inputCursorLeft = Console.CursorLeft;
            var inputCursorTop = Console.CursorTop;

            string values = "";

            for (ushort i = 0; i < iterations; ++i)
            {
                Console.WriteLine($"Values entered: [{values}]");

                Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(inputCursorLeft, inputCursorTop);

                entries[i] = Helper.GetInput("Enter #: ", new int[] { });

                // Add first value in array without a comma.
                if (i == 0)
                {
                    values = values.Insert(0, entries[i].ToString());
                }
                // Add value in front of the array with a comma.
                else
                {
                    values = values.Insert(0, entries[i].ToString() + ", ");
                }

                // Return the cursor to the input and clear user input.
                if (i < iterations - 1)
                {
                    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                }
                // Display the last user input.
                else
                {
                    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                    Console.WriteLine($"Values entered: [{values}]");
                    Console.Write(new string(' ', Console.WindowWidth));
                }
            }

            Console.WriteLine("The sum is: {0}",Sum(entries));
            Console.WriteLine("The avg is: {0}",Avg(entries));
            Console.WriteLine("The min is: {0}", Min(entries));
            Console.WriteLine("The max is: {0}", Max(entries));
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey(true);
        }
    }
}
