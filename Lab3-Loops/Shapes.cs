// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab3 - Loops
//  Version: 1.0
//
//  Description: Perform a number of opertions using loops.
//
//  Shapes.cs
//
//  Author:
//       Christian Lachapelle <lachapellec@gmail.com>
//
//  Copyright (c) 2020 Devworks8
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
using System.Collections.Generic;

namespace Lab3Loops
{
    public static class Patterns
    {
        // Square pattern matrix
        private static byte[,] square = new byte[7, 7] {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 }};

        // Rectangle pattern matrix
        private static byte[,] rectangle = new byte[7, 7] {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }};

        // Parallelogram Left pattern matrix
        private static byte[,] parallelLeft = new byte[7, 7] {
            { 0, 0, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }};

        // Parallelogram Right pattern matrix
        private static byte[,] parallelRight = new byte[7, 7] {
            { 1, 1, 1, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }};

        // Triangle Bottom Left pattern matrix
        private static byte[,] triangleBottomLeft = new byte[7, 7] {
            { 1, 0, 0, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 0, 0, 0 },
            { 1, 1, 1, 0, 0, 0, 0 },
            { 1, 1, 1, 1, 0, 0, 0 },
            { 1, 1, 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 1 }};

        // Triangle Bottom Right pattern matrix
        private static byte[,] triangleBottomRight = new byte[7, 7] {
            { 0, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 1, 1 },
            { 0, 0, 0, 0, 1, 1, 1 },
            { 0, 0, 0, 1, 1, 1, 1 },
            { 0, 0, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 }};

        // Triangle Top Left pattern matrix
        private static byte[,] trianlgeTopLeft = new byte[7, 7] {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 0, 0, 0 },
            { 1, 1, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 }};

        // Triangle Top Right pattern matrix
        private static byte[,] triangleTopRight = new byte[7, 7] {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 1 }};

        // Diamond pattern matrix
        private static byte[,] diamond = new byte[7, 7] {
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 1, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 }};

        // Circle pattern matrix
        private static byte[,] circle = new byte[7, 7] {
            { 0, 0, 1, 1, 1, 0, 0 },
            { 0, 1, 1, 1, 1, 1, 0 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 0, 1, 1, 1, 1, 1, 0 },
            { 0, 0, 1, 1, 1, 0, 0 }};

        public static Dictionary<byte, byte[,]> pattern = new Dictionary<byte, byte[,]>() {
            {1, square },
            {2, rectangle },
            {3, parallelLeft },
            {4, parallelRight },
            {5, triangleBottomLeft },
            {6, triangleBottomRight },
            {7, trianlgeTopLeft },
            {8, triangleTopRight },
            {9, diamond },
            {10,circle } };   
    }

    public static class Shapes
    {
        // Parse and display the pattern matrix
        private static void ParsePattern(byte[,] pattern)
        {
            for (byte i = 0; i < 7; ++i)
            {
                for (byte j = 0; j < 7; ++j)
                {
                    Console.Write(pattern[i,j] == 0 ? "  " : "* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintShapes()
        {
            string menu = String.Format(@"
{0,-40}
{1,-40}
{2,-40}
{3,-40}
{4,-40}
{5,-40}
{6,-40}
{7,-40}
{8,-40}
{9,-40}
{10,-40}

",
"1) Square",
"2) Rectangle",
"3) Parallelogram Left",
"4) Parallelogram Right",
"5) Triangle Bottom Left",
"6) Triangle Bottom Right",
"7) Triangle Top Left",
"8) Triangle Top Right",
"9) Diamond",
"10) Circle",
"11) All");


            Console.Write("\nDo you want to print shapes? [Y/n] ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y" | string.IsNullOrEmpty(input))
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(menu);
                    Console.Write("Selection [defailt=All]: ");
                    // Capture cursor position
                    var inputCursorLeft = Console.CursorLeft;
                    var inputCursorTop = Console.CursorTop;

                    input = Console.ReadLine();

                    input = String.IsNullOrEmpty(input) ? "11" : input;

                    // Check if input is a valid number.
                    bool num;
                    try
                    {
                        Byte.Parse(input);
                        num = true;
                    }
                    catch
                    {
                        num = false;
                    }

                    if (num)
                    {
                        // Is the input valid
                        if (Convert.ToByte(input) > 0 | Convert.ToByte(input) < 12)
                        {
                            // Display all patterns.
                            if (Convert.ToByte(input) == 11)
                            {
                                for (byte shape = 1; shape < 11; ++shape)
                                {
                                    ParsePattern(Patterns.pattern[shape]);
                                    Console.WriteLine();
                                }
                            }
                            // Display user selected pattern.
                            else
                            {
                                ParsePattern(Patterns.pattern[Convert.ToByte(input)]);
                            }
                        }
                        // Display error message if not in range
                        else
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
                    }
                    // Display error message if not a number
                    else
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

                    Console.Write("\nAgain? [Y/n]: ");
                    input = Console.ReadLine();

                    if (input.ToUpper() == "N")
                    {
                        break;
                    }
                }
            }
        }
    }
}
