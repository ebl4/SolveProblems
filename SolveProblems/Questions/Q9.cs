using System;

public class Q9
{

    public static string Similar(string word)
    {
        int zCount = 0, oCount = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'z') zCount++;
            else if (word[i] == 'o') oCount++;
        }

        return zCount * 2 == oCount ? "Yes" : "No";
    }

    public static void Main()
    {
        string word = Console.ReadLine()!;

        Console.WriteLine(Similar(word));
    }
}
