//www.codingame.com/ide/puzzle/power-of-thor-episode-1
using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

        int thorx = initialTX;
        int thory = initialTY;

        while (true)
        {
            string directionx = "";
            string directiony = "";
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            if (thorx > lightX)
            {
                directionx = "W";
                thorx--;
            }
            else if (thorx < lightX)
            {
                directionx = "E";
                thorx++;
            }
            if (thory > lightY)
            {
                directiony = "N";
                thory--;
            }
            else if (thory < lightY)
            {
                directiony = "S";
                thory++;
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(directiony + directionx);
        }
    }
}