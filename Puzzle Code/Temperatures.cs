//www.codingame.com/ide/puzzle/temperatures
using System;

class Solution
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int smallNo = 5526;
        if (n == 0)
        {
            smallNo = n;
        }
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
                                         //Console.WriteLine(t);

            if (Math.Abs(smallNo) >= Math.Abs(t))
            {
                if (smallNo == t)
                {
                    smallNo = t;
                }
                else if (Math.Abs(smallNo) == Math.Abs(t))
                {
                    smallNo = Math.Abs(t);
                }
                else
                {
                    smallNo = t;
                }
            }

        }


        Console.WriteLine(smallNo);
    }
}