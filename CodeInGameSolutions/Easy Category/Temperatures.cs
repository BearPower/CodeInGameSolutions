using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: Temperatures
Description: Salution to a programing puzzle named Temperatures, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/temperatures
Language: C#
Author: Konstantin N. Tomov
Date: 02/04/2020
==========================================*/

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        Console.Error.WriteLine(n);
        string[] inputs = Console.ReadLine().Split(' ');
        //initialize the result to sero 
        int result = 5526;
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            if(t<0){
                int posTemp=t*-1;
                int posResult=result;
                if(result<0){
                    posResult = result*-1;
                }
                if(posTemp<posResult){
                    result=t;
                }
            }
            if(t>=0){
                int posResult=result;
                if(result<0){
                    posResult = result*-1;
                }
                if(t<=posResult){
                    result=t;
                }
            }
        }
        if(n==0){
            result = 0;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(result);
    }
}