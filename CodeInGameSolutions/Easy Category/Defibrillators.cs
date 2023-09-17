using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*==========================================
Title: Defibrillators
Description: Salution to a programing puzzle named Defibrillators, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/defibrillators
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
        // Getting the Person langitude and latitude and converting it to double.
        double PersonLongitude = Convert.ToDouble(Console.ReadLine().Replace(",","."));
        double PersonLatitude = Convert.ToDouble(Console.ReadLine().Replace(",","."));
        int N = int.Parse(Console.ReadLine());
        double BestDistanseFound = 0; // Holder for best distance found
        string ClosestDifibrillatorName= "None";

        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            // Splitting the input in usable parts by ";"
            string[] DefibSplit = DEFIB.Split(";");
            string DefibIdentifier = DefibSplit[0];
            string DefibName = DefibSplit[1];
            string DefibAddress = DefibSplit[2];
            string DefibContactPhoneNumber = DefibSplit[3];
            double DefibLongitude = Convert.ToDouble(DefibSplit[4].Replace(",",".")); // Replace the "," with "." and convert to double
            double DefibLatitude = Convert.ToDouble(DefibSplit[5].Replace(",",".")); // Replace the "," with "." and convert to double
            //Console.Error.WriteLine("Debug msg: Defibrillator Longitude = " + DefibLongitude);
            //Console.Error.WriteLine("Debug msg: Defibrillator Latitude = " + DefibLatitude);
            // Calculating the distance to Defibrillator
            double Distance = Math.Sqrt(Math.Pow((DefibLongitude - PersonLongitude)*Math.Cos((PersonLatitude+DefibLatitude)/2),2)+Math.Pow((DefibLatitude - PersonLatitude),2))*6371;
            //Console.Error.WriteLine("Debug msg: Distance to Defibrillator is = " + Distance);
            // Checking if there is defibllirator already selected.
            if(ClosestDifibrillatorName=="None"){
                BestDistanseFound = Distance;
                ClosestDifibrillatorName = DefibName;
            }
            // Cheking if current defibrillator is closer than closest one found and replase it.
            else{
                if(BestDistanseFound>Distance){
                    BestDistanseFound = Distance;
                    ClosestDifibrillatorName = DefibName;
                }
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(ClosestDifibrillatorName);
    }
}