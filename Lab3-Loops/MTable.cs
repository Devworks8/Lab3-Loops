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


        private static void Top(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j <= range; j++)
                {
                    if (j >= i)
                    {
                        Console.Write(String.Format("{0, 4} ", i * j));
                    }
                    else
                    {
                        Console.Write(String.Format("{0, 4} ", ""));
                    }
                    //Console.Write(String.Format("{0, 4} ", i * j));
                }
                Console.WriteLine();
            }
        }

        private static void Bottom(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j <= range; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(String.Format("{0, 4} ", i * j));
                    }
                    else
                    {
                        Console.Write(String.Format("{0, 4} ", ""));
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Complete(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j <= range; j++)
                {
                    if (j == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(String.Format("{0, 4} ", i * j));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(String.Format("{0, 4} ", i * j));
                    }

                }
                Console.WriteLine();
            }
        }

        public static void ShowTable()
        {
            

            int range;
            range = (int)Helper.GetInput(String.Format("How many # to calculate [range: 2 to {0} Default=10]? ", Console.WindowWidth / 5), new int[] { 2, Console.WindowWidth / 5 }, true);



            //// Capture cursor position
            //var inputCursorLeft = Console.CursorLeft;
            //var inputCursorTop = Console.CursorTop;

            //while (range >1 ^ range < Console.WindowWidth / 5+1)
            //{
            //    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
            //    Console.Write(new string(' ', Console.WindowWidth));
            //    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
            //    range = (int)Helper.GetInput(String.Format("How many # to calculate [range: 2 to {0} Default=10]? ", Console.WindowWidth / 5), true);


            //    //// Erase the last error message (if there was one)
            //    //Console.Write(new string(' ', Console.WindowWidth));
            //    //Console.ForegroundColor = ConsoleColor.Red;

            //    ///* PadRight ensures that this line extends the width
            //    // * of the console window so it erases the width of the
            //    // * console window so it erases itself each time
            //    // */
            //    //Console.Write("\bERROR: Invalid input".PadRight(Console.WindowWidth));
            //    //Console.ResetColor();

            //    ///* Set the cursor position to just after the prompt again, 
            //    // * and write a blank line and reset the cursor once more.
            //    // */
            //    //Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
            //    //Console.Write(new string(' ', Console.WindowWidth));
            //    //Console.SetCursorPosition(inputCursorLeft, inputCursorTop);



            //}

            //byte selection;
            //selection = (byte)Helper.GetInput("Display pattern: 1=Top, 2=Bottom, 3=Full, 4=All: ");

            ////inputCursorLeft = Console.CursorLeft;
            ////inputCursorTop = Console.CursorTop-2;

            //while (selection > 0 ^ selection < 5)
            //{
            //    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
            //    Console.Write(new string(' ', Console.WindowWidth));
            //    Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
            //    selection = (byte)Helper.GetInput("Display pattern: 1=Top, 2=Bottom, 3=Full, 4=All: ");


            //    //// Erase the last error message (if there was one)
            //    //Console.Write(new string(' ', Console.WindowWidth));
            //    //Console.ForegroundColor = ConsoleColor.Red;

            //    ///* PadRight ensures that this line extends the width
            //    // * of the console window so it erases the width of the
            //    // * console window so it erases itself each time
            //    // */
            //    //Console.Write("\bERROR: Invalid input".PadRight(Console.WindowWidth));
            //    //Console.ResetColor();

            //    ///* Set the cursor position to just after the prompt again, 
            //    // * and write a blank line and reset the cursor once more.
            //    // */
            //    //Console.SetCursorPosition(inputCursorLeft, inputCursorTop);
            //    //Console.Write(new string(' ', Console.WindowWidth));
            //    //Console.SetCursorPosition(inputCursorLeft, inputCursorTop);


            //    selection = (byte)Helper.GetInput("Display pattern: 1=Top, 2=Bottom, 3=Full, 4=All: ");
            //}

            int selection;
            selection = (int)Helper.GetInput("Display pattern: 1=Top, 2=Bottom, 3=Full, 4=All: ", new int[] { 1, 4 });
            //TODO: Add header and sidebar
            if (selection == 4)
            {
                Complete(range);
                Console.WriteLine("\n");
                Console.ReadKey(true);
                Top(range);
                Console.WriteLine("\n");
                Console.ReadKey(true);
                Bottom(range);
                Console.WriteLine("\n");
                Console.ReadKey(true);
            }
            else if (selection == 3)
            {
                Complete(range);
                Console.WriteLine("\n");
                Console.ReadKey(true);
            }
            else if (selection == 2)
            {
                Bottom(range);
                Console.WriteLine("\n");
                Console.ReadKey(true);
            }
            else if (selection == 1)
            {
                Top(range);
                Console.WriteLine("\n");
                Console.ReadKey(true);
            }
            
        }
    }
}
