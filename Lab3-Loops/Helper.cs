// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: 
//  Version: 
//
//  Description: 
//
//
// Helper.cs
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
    public static class Helper
    {
        // This method adds padding to a string to center align
        public static string CenterAligned(string s, int width)
        {
            if (s.Length >= width)
            {
                return s;
            }

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }

        public static decimal GetInput(string message, int[] vrange, bool isRange = false, uint defaults=10)
        {
            
            Console.Write(message);

            // Capture cursor position
            var inputCursorLeft = Console.CursorLeft;
            var inputCursorTop = Console.CursorTop;


            string input;
            decimal output;

            while (true)
            {
                input = Console.ReadLine();

                if (!decimal.TryParse(input, out output) && !String.IsNullOrEmpty(input))
                {
                    // Erase the last error message (if there was one)
                    Console.Write(new string(' ', input.Length));
                    Console.ForegroundColor = ConsoleColor.Red;

                    /* PadRight ensures that this line extends the width
                     * of the console window so it erases the width of the
                     * console window so it erases itself each time
                     */
                    Console.Write("\bERROR: Invalid input".PadRight(input.Length));
                    Console.ResetColor();

                    /* Set the cursor position to just after the prompt again, 
                     * and write a blank line and reset the cursor once more.
                     */
                    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                    Console.Write(new string(' ', input.Length));
                    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                }
                else if (vrange.Length > 0)
                {
                    //TODO: Logic not working as needed. It allows NaNs
                    if ((int)output < vrange[0] | (int)output > vrange[1] && !String.IsNullOrEmpty(input))
                    {
                        // Erase the last error message (if there was one)
                        Console.Write(new string(' ', input.Length));
                        Console.ForegroundColor = ConsoleColor.Red;

                        /* PadRight ensures that this line extends the width
                         * of the console window so it erases the width of the
                         * console window so it erases itself each time
                         */
                        Console.Write("\bERROR: Invalid input".PadRight(input.Length));
                        Console.ResetColor();

                        /* Set the cursor position to just after the prompt again, 
                         * and write a blank line and reset the cursor once more.
                         */
                        Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                        Console.Write(new string(' ', input.Length));
                        Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            Console.Write(new string(' ', Console.WindowWidth));

            if (isRange)
            {
                return String.IsNullOrEmpty(input) ? (decimal)defaults : output;
            }

            return output;
        }
    }
}
