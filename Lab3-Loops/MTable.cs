// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: 
//  Version: 
//
//  Description: 
//
//
// MTable.cs
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
    public static class MTable
    {
        public static void multitable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(String.Format("{0, 4} ", i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }


        public static void ShowTable(int range, bool showTop=false, bool showAll=false)
        {
            // Capture cursor position
            var inputCursorLeft = Console.CursorLeft;
            var inputCursorTop = Console.CursorTop-2;

            while (range >=2 ^ range <= Console.WindowWidth / 5)
            {
                // Erase the last error message (if there was one)
                Console.Write(new string(' ', Console.WindowWidth));
                Console.ForegroundColor = ConsoleColor.Red;

                /* PadRight ensures that this line extends the width
                 * of the console window so it erases the width of the
                 * console window so it erases itself each time
                 */
                Console.Write("\bERROR: Invalid input".PadRight(Console.WindowWidth));
                Console.ResetColor();

                /* Set the cursor position to just after the prompt again, 
                 * and write a blank line and reset the cursor once more.
                 */
                Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(inputCursorLeft, inputCursorTop);


                range = (int)Helper.GetInput(String.Format("How many # to calculate [range: 2 to {0} Default=10]? ", Console.WindowWidth / 5), true);
            }

            //TODO: Add header and sidebar
            if (showAll)
            {
                //TODO: Color diag
                for (int i = 1; i <= range; i++)
                {
                    for (int j = 1; j <= range; j++)
                    {
                        Console.Write(String.Format("{0, 4} ", i * j));
                    }
                    Console.WriteLine();
                }
                Console.ReadKey(true);
            }
            else if (showTop)
            {
                //TODO: Only show top half
                for (int i = 1; i <= range; i++)
                {
                    for (int j = 1; j <= range; j++)
                    {
                        Console.Write(String.Format("{0, 4} ", i * j));
                    }
                    Console.WriteLine();
                }
                Console.ReadKey(true);
            }
            else
            {
                // TODO: Only show bottom half
                for (int i = 1; i <= range; i++)
                {
                    for (int j = 1; j <= range; j++)
                    {
                        Console.Write(String.Format("{0, 4} ", i * j));
                    }
                    Console.WriteLine();
                }
                Console.ReadKey(true);
            }
            
        }
    }
}
