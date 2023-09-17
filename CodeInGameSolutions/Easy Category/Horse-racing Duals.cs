using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: Horse-racing Duals
Description: Salution to a programing puzzle named Horse-racing Duals, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/horse-racing-duals
Language: C#
Author: Konstantin N. Tomov
Date: 02/04/2023
==========================================*/

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var OrderedList = new List<int>{}; // List to hold all the numbers
        int SmallestDiff = 10000000;

        // Adding all the numbers to the list
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            OrderedList.Add(pi);
        }

        // Sorting the list in order
        OrderedList.Sort();
        // Comparing consequent numbers and recording the smallest difference
        for (int i = 1; i < N; i++){
            if(SmallestDiff>(OrderedList[i] - OrderedList[i-1])){
                SmallestDiff = OrderedList[i] - OrderedList[i-1];
            }
            //Console.Error.WriteLine("Debug msg: List items in oeder:" + OrderedList[i]);
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(SmallestDiff); // Autputing the smallest number back to the console.
    }
}