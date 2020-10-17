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

        private static string AddHeader(int range)
        {
            string header=@"        ";

            for (int i = 1; i <= range; i++)
            {
                header += String.Format("{0, 4} ", i);
            }

            header += "\n        ";

            for (int i = 1; i <= range; i++)
            {
                header += Helper.CenterAligned(String.Format("{0, 4} ", "|"), 4);
            }

            header += "\n        ";

            for (int i = 1; i <= range; i++)
            {
                header += Helper.CenterAligned(String.Format("{0, 4} ", "V"), 4);
            }
 
            return header+="\n";
        }

        private static void Top(int range)
        {
            Console.WriteLine(AddHeader(range));

            for (int i = 1; i <= range; i++)
            {
                Console.Write(String.Format("{0,4} {1,3}", i, "-> "));
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
                }
                Console.WriteLine();
            }
        }

        private static void Bottom(int range)
        {
            Console.WriteLine(AddHeader(range));
            for (int i = 1; i <= range; i++)
            {
                Console.Write(String.Format("{0,4} {1,3}", i, "-> "));
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
            Console.WriteLine(AddHeader(range));
            for (int i = 1; i <= range; i++)
            {
                Console.Write(String.Format("{0,4} {1,3}", i, "-> "));
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
            int range = (int)Helper.GetInput(String.Format("How many # to calculate [range: 2 to {0} [default=10]? ", Console.WindowWidth / 5), new int[] { 2, Console.WindowWidth / 5 }, true);

            int selection = (int)Helper.GetInput("Display pattern: 1=Top, 2=Bottom, 3=Full, 4=All [default=4]: ", new int[] { 1, 4 }, true, 4);

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
