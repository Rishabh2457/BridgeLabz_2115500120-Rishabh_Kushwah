using System;

class CountVolCon
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string s1 = Console.ReadLine();
        
        Count(s1);
    }

    static void Count(string s1)
    {
        char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int countVol = 0;
        int countCons = 0;
        
        foreach (char c in s1)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                bool isVowel = false; 
                
                for (int i = 0; i < vowel.Length; i++)
                {
                    if (c == vowel[i])
                    {
                        isVowel = true;
                        countVol++;
                        break;
                    }
                }

                if (!isVowel)
                {
                    countCons++;
                }
            }
        }

        Console.WriteLine("Vowels: " + countVol);
        Console.WriteLine("Consonants: " + countCons);
    }
}
