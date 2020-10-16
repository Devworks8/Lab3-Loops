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
        public static double GetInput(string message, bool isLoop=false, ushort defaults=10)
        {
            Console.Write(message);

            // Capture cursor position
            var inputCursorLeft = Console.CursorLeft;
            var inputCursorTop = Console.CursorTop;

            //TODO: Need to check for m/t user input
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
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

            }

            Console.Write(new string(' ', Console.WindowWidth));

            if (isLoop)
            {
                return !String.IsNullOrEmpty(input.ToString()) ? (double)defaults : (double)input;
            }

            return input;
        }
    }
}
