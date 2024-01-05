



//3.How to reverse each word in a given string?
//Input: Welcome to Csharp corner
//Output: emocleW ot prahsC renroc 

using System;
class Program
{
    static void Main()
    {

        string inputString = "Welcome to Csharp corner";
        string outputString = ReverseWords(inputString);

        Console.WriteLine(outputString);
    }

    static string ReverseWords(string inputString)
    {

        string[] words = inputString.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();


            Array.Reverse(charArray);

            words[i] = new string(charArray);
        }

        string outputString = string.Join(" ", words);
        return outputString;
    }
}
