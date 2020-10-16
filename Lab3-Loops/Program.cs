// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: 
//  Version: 
//
//  Description: 
//
//
// Program.cs
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
    class MainClass
    {
        public void multitable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(String.Format("{0, 3} ", i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Lets find the sum, avg, min, and max.\n");
            SAMM.Calculate((ushort)Helper.GetInput("How many # do you want to enter [default=10]? ", true));

            Console.WriteLine("Lets calculate \u03a0 (Pi).");

            // Capture cursor position
            //var inputCursorLeftPie = Console.CursorLeft;
            //var inputCursorTopPie = Console.CursorTop;

            Pie.Calculate((uint)Helper.GetInput("How many iterations? ", true));
        }
    }
}
