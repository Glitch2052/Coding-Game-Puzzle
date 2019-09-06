//www.codingame.com/ide/puzzle/ascii-art
using System;

class Solution
{
    static void Main()
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string Sentence = Console.ReadLine().ToUpper();

        for (int i = 0; i < H; i++)
        {
            string AsciiRow = Console.ReadLine();
            foreach (char letter in Sentence)
            {
                int index = char.IsLetter(letter) ? letter - 65 : 26;
                Console.Write(AsciiRow.Substring(index * L, L));
            }
            Console.WriteLine();
        }
    }
}