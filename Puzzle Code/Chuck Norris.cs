//www.codingame.com/training/easy/chuck-norris
using System;
using System.Text;


class Solution
{
    static void Main(string[] args)
    {
        string Message = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        string input = StringToBinary(Message);
        char previous = '2';
        Console.Error.WriteLine(input);
        for (int i = 0; i < input.Length; i++)
        {
            if (previous != input[i])
            {
                if (previous != '2')
                {
                    result.Append(" ");
                }
                result.Append('1' == input[i] ? "0 " : "00 ");
                previous = input[i];

                
            }
            result.Append('0');
            
        }

        Console.WriteLine(result);
    }
    public static string StringToBinary(string data)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in data.ToCharArray())
        {
            sb.Append(Convert.ToString(c, 2).PadLeft(7, '0'));
        }
        return sb.ToString();
    }
}