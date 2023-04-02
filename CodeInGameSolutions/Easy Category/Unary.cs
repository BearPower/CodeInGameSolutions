using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: Unary
Description: Salution to a programing puzzle named Unary, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/unary
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
        string MESSAGE = Console.ReadLine();
        string binary = "";
        string result = "";
        char oldBit = ' ';
        int startCount = 0;
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        for(int letter=0;letter<MESSAGE.Length;letter++){
            binary= Convert.ToString(MESSAGE[letter],2).PadLeft(7, '0');
            for(int bites=0;bites<binary.Length;bites++){
                if(binary[bites]!=oldBit){
                    if(startCount>0){
                        result=result+" ";
                    }
                    startCount++;
                    if(binary[bites]=='0'){
                        result = result+"00 0";
                    }
                    if(binary[bites]=='1'){
                        result = result+"0 0";
                    }
                }else{
                    result = result+"0";
                }
                oldBit=binary[bites];
            }
        }
        Console.Error.WriteLine(MESSAGE);
        Console.Error.WriteLine(binary);
        Console.WriteLine(result);
    }
}