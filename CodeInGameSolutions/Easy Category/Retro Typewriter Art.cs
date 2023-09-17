using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: Retro Typewriter Art
Description: Salution to a programing puzzle named Retro Typewriter Art, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/retro-typewriter-art
Language: C#
Author: Konstantin N. Tomov
Date: 03/04/2023
==========================================*/

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

class Solution
{
    static void Main(string[] args)
    {
        List<string> Result  = new List<string>(); // Holder for the result, every element of the list holds one line
        string CurLine = ""; // Holder for the current line

        string T = Console.ReadLine();
        // spliting the sting by " " for use
        string[] Instructions = T.Split(" ");
        // Go thrugh every instruction and make it into the final output with the provided abbreviations 
        foreach(string Instruction in Instructions){
             // Check if the instriction ends on "sp" (space)
            if(Instruction[Instruction.Length-2] == 's' && Instruction[Instruction.Length-1] == 'p'){
                int RepeatTimes= Int32.Parse(Instruction.Remove(Instruction.Length-2)); // Get the amount of repetition
                for(int i = 0; i < RepeatTimes; i++){
                    CurLine = CurLine + ' ';
                }
                //Console.Error.WriteLine("Debug msg: " + RepeatTimes + " number of spaces added." );
            }
             // Check if the instriction ends on "bS" (\)
            else if(Instruction[Instruction.Length-2] == 'b' && Instruction[Instruction.Length-1] == 'S'){
                int RepeatTimes= Int32.Parse(Instruction.Remove(Instruction.Length-2)); // Get the amount of repetition
                for(int i = 0; i < RepeatTimes; i++){
                    CurLine = CurLine + '\\';
                }
                //Console.Error.WriteLine("Debug msg: " + RepeatTimes + " number of \\ added." );
            }
             // Check if the instriction ends on "sQ" (')
            else if(Instruction[Instruction.Length-2] == 's' && Instruction[Instruction.Length-1] == 'Q'){
                int RepeatTimes= Int32.Parse(Instruction.Remove(Instruction.Length-2)); // Get the amount of repetition
                for(int i = 0; i < RepeatTimes; i++){
                    CurLine = CurLine + '\'';
                }
                //Console.Error.WriteLine("Debug msg: " + RepeatTimes + " number of \' added." );
            }
             // Check if the instriction ends on "nl" (new line)
            else if(Instruction[Instruction.Length-2] == 'n' && Instruction[Instruction.Length-1] == 'l'){
                Result.Add( CurLine);
                CurLine = ""; // Reset the holder
                //Console.Error.WriteLine("Debug msg: End of the line." );
            }
             // Else the Instruction is a charecter
            else {
                int RepeatTimes= Int32.Parse(Instruction.Remove(Instruction.Length-1)); // Get the amount of repetition
                for(int i = 0; i < RepeatTimes; i++){
                    CurLine = CurLine + Instruction[Instruction.Length-1];
                }
                //Console.Error.WriteLine("Debug msg: "+ RepeatTimes + " number of " + Instruction[Instruction.Length-1] + " added." );
            }
        }
        // Adding last line to result due the recipe finishing not on a new line.
        Result.Add( CurLine);
        //Console.Error.WriteLine("Debug msg: End of the line." );

        // Wtring the result to console
        foreach( string Line in Result){
            Console.WriteLine(Line);
        }
    }
}