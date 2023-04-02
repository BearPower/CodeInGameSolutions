using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: MIME Type
Description: Salution to a programing puzle named MIME Type, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/mime-type
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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        string[][] MimeTable = new string[N][]; // 2D array to hold the MIME Table
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            // populating the array with the MIME table
            MimeTable[i] = new string[]{"",""}; 
            MimeTable[i][0] = EXT.ToLower(); // Making the Extension the the table case insensitive
            MimeTable[i][1] = MT;
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            // Console.Error.WriteLine("Debug msg: File name is "+FNAME+"");
            if (FNAME.Contains(".") || FNAME[FNAME.Length-1] == '.'){ // Cheking if the file name containes proper defines extention
                string[] FileNameSplit = FNAME.Split("."); // Separating the extension
                string Extention = FileNameSplit[FileNameSplit.Length-1].ToLower(); // Making the File extension case insensitive
                bool Found = false;
                // Console.Error.WriteLine("Debug msg: File extection is "+Extention);
                // Looping through MIME table
                for (int z = 0; z < N; z++){
                    // Console.Error.WriteLine("Debug msg: Table extection is "+MimeTable[z][0]);
                    // Comperring file extention to current extention from table
                    if(MimeTable[z][0] == Extention){
                        //Console.Error.WriteLine("Debug msg: File extextion found.");
                        Console.WriteLine(MimeTable[z][1]); // Writing the current MIME type of the extension found in the table to the console.
                        Found = true;
                        break;
                    }
                }
                if (!Found){
                    Console.WriteLine("UNKNOWN"); // Writing answer to console for MIME not found in table by extention.
                }  
            }else{
                //Console.Error.WriteLine("Debug msg: File doesn't have extention or ends on a dot.");
                Console.WriteLine("UNKNOWN"); // Writing answer to console for bad foramt of the file name.
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
    }
}