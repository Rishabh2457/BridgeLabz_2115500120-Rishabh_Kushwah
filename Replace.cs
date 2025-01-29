using System;
using System.Text;

class Replace
{
    public static string ReplaceWord(string str, string oldWord, string newWord)
    {
        StringBuilder result = new StringBuilder();
        int i = 0;
        
        while (i < str.Length)
        {
            int j = 0, start = i;

            while (j < oldWord.Length && start < str.Length && str[start] == oldWord[j])
            {
                j++;
                start++;
            }

            // If full word matches, replace it
            if (j == oldWord.Length)
            {
                result.Append(newWord);
                i += oldWord.Length;
            }
            else
            {
                result.Append(str[i]);
                i++;
            }
        }

        return result.ToString();
    }

    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        Console.WriteLine("Enter word to replace:");
        string oldWord = Console.ReadLine();
        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        string res = ReplaceWord(str, oldWord, newWord);

        Console.WriteLine("Updated sentence: " + res);
    }
}
