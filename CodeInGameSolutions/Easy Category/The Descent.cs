using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: The Descent
Description: Salution to a programing puzzle named The Descent, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/the-descent
Language: C#
Author: Konstantin N. Tomov
Date: 02/04/2020
==========================================*/

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int targetIndicator=0;
            int targetHight=0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                //tests if the new mountain is bigger then the previously bigest found
                if(mountainH>targetHight){
                    //if it is bigger record the new hight for comperesent and the the target index as a salution
                    targetHight=mountainH;
                    targetIndicator=i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(targetIndicator); // The index of the mountain to fire on.

        }
    }
}