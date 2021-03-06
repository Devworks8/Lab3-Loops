﻿// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab3 - Loops
//  Version: 1.0
//
//  Description: Perform a number of opertions using loops.
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
        public static void Main(string[] args)
        {
            Console.Clear();
            // Find the sum/avg/min/max of a list of numbers.
            Console.WriteLine("Lets find the sum, avg, min, and max.\n");
            SAMM.Calculate((ushort)Helper.GetInput("How many # do you want to enter [default=10]? ",new int[] { }, true));
            // Calculate PI.
            Console.WriteLine("Lets calculate PI.\n"); 
            Pie.Calculate((uint)Helper.GetInput("How many iterations [default=100,000]? ", new int[] { }, true, 100000));
            //Show multiplication table.
            Console.WriteLine("\nLet show the multiplaction table.\n");
            MTable.ShowTable();
            // Print shapes.
            Shapes.PrintShapes();
        }
    }
}
