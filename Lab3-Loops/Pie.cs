// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab3 - Loops
//  Version: 1.0
//
//  Description: Perform a number of opertions using loops.
//
//  Pie.cs
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

namespace Lab3Loops
{
    public static class Pie
    {
        // Calculate PI and display results.
        public static void Calculate(uint iterations)
        {
            bool isAdd = false;
            decimal pie = 0.0M;

            for (uint i = 1; i <= iterations; i += i % 2 == 0 ? (uint)1 : (uint)2)
            {
                if (pie == 0.0M)
                {
                    pie += 4.0M / i;
                }
                else if (isAdd)
                {
                    pie += 4.0M / i;
                    isAdd = false;
                }
                else
                {
                    pie -= 4.0M / i;
                    isAdd = true;
                }
            }

            Console.WriteLine("{0,40}{1,-30}","The value calculate is: ",pie);
            Console.WriteLine("{0,40}{1,-30}","The value reported by Math.PI() is: ",Math.PI);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
