using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: Power of Thor - Episode 1
Description: Salution to a programing puzzle named Power of Thor - Episode 1, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/power-of-thor-episode-1
Language: C#
Author: Konstantin N. Tomov
Date: 02/04/2020
==========================================*/

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            if(lightX>initialTx){
                if(lightY==initialTy){
                    Console.WriteLine("E");
                    initialTx=initialTx+1;
                }
                if(lightY<initialTy){
                    Console.WriteLine("NE");
                    initialTx=initialTx+1;
                    initialTy=initialTy-1;
                }
                if(lightY>initialTy){
                    Console.WriteLine("SE");
                    initialTx=initialTx+1;
                    initialTy=initialTy+1;
                }
            }
            if(lightX<initialTx){
                if(lightY==initialTy){
                    Console.WriteLine("W");
                    initialTx=initialTx-1;
                }
                if(lightY<initialTy){
                    Console.WriteLine("NW");
                    initialTx=initialTx-1;
                    initialTy=initialTy-1;
                }
                if(lightY>initialTy){
                    Console.WriteLine("SW");
                    initialTx=initialTx-1;
                    initialTy=initialTy+1;
                }
            }
            if(lightX==initialTx){
                if(lightY<initialTy){
                    Console.WriteLine("N");
                    initialTy=initialTy+1;
                }
                if(lightY>initialTy){
                    Console.WriteLine("S");
                    initialTy=initialTy-1;

                }
            }
        }
    }
}