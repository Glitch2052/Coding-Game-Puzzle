//www.codingame.com/ide/puzzle/shadows-of-the-knight-episode-1
using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        int LX = 0, LY = 0, HX = W - 1, HY = H - 1;


        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            Console.Error.WriteLine(bombDir);
            if (bombDir.Length > 1)
            {
                if (bombDir[0] == 'U')
                {
                    HY = Y0 - 1;
                }
                else if (bombDir[0] == 'D')
                {
                    LY = Y0 + 1;
                }
                if (bombDir[1] == 'R')
                {
                    LX = X0 + 1;
                }
                else
                {
                    HX = X0 - 1;
                }
            }
            else
            {
                if (bombDir[0] == 'L')
                {
                    HX = X0 - 1;
                }
                else if (bombDir[0] == 'R')
                {
                    LX = X0 + 1;
                }
                else if (bombDir[0] == 'U')
                {
                    HY = Y0 - 1;
                }
                else if (bombDir[0] == 'D')
                {
                    LY = Y0 + 1;
                }
            }
            X0 = (LX + HX) / 2;
            Y0 = (LY + HY) / 2;
            Console.WriteLine(X0 + " " + Y0);

        }
    }
}