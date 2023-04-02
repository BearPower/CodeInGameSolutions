using System;

/*==========================================
Title: Onboarding
Description: Salution to a programing puzzle named Onboarding, found on CodInGame.
Link: https://www.codingame.com/ide/puzzle/onboarding
Language: C#
Author: Konstantin N. Tomov
Date: 02/04/2020
==========================================*/

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string enemy1 = Console.ReadLine(); // name of enemy 1
            int dist1 = int.Parse(Console.ReadLine()); // distance to enemy 1
            string enemy2 = Console.ReadLine(); // name of enemy 2
            int dist2 = int.Parse(Console.ReadLine()); // distance to enemy 2

            // Write an action using Console.WriteLine()

            if (dist1 < dist2) {
                Console.WriteLine(enemy1);
            } else {
                Console.WriteLine(enemy2);
            }
            // Enter the code here

        }
    }
}