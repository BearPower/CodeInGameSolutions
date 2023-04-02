using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: ASCII Art
Description: Salution to a programing puzzle named ASCII ART, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/ascii-art
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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string ASCIImap="";
        string result= "";
        int lineL=0;
        // making map of the ASCII input
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            ASCIImap = ASCIImap+ROW;
            lineL = ROW.Length;
        } 
        for(int y=0;y<H;y++){
            //woop true every simbul in the input
            for (int i=0;i<T.Length;i++){
                //making all letter capital in order to make there value the same.
                char upperCase=char.ToUpper(T[i]);
                // taking the letter number
                int upperCaseNum = upperCase-65; 
                if(upperCaseNum>25 || upperCaseNum<0){
                    upperCaseNum=26;
                }
                // find and make the letter from the ascii map
                //Console.Error.WriteLine(upperCaseNum);
                for(int a=0;a<L;a++){
                    result = result+ASCIImap[((upperCaseNum*L)+a)+(lineL*(y))];
                } 
            }
            //clear the result holder 
            //Console.Error.WriteLine(upperCaseNum);
            Console.WriteLine(result);
            result="";
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

       
    }
}