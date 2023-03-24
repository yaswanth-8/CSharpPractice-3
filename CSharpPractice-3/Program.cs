using System.Collections.Generic;
using System.Globalization;

namespace MyProject;
class Program
{
    public static string Replace(string str, char first, char last)
    {
        if (str.Length < 2)
        {
            return str;
        }
        else
        {
            string newWord = str.Remove(0, 1);
            newWord = newWord.Remove(newWord.Length - 1, 1);
            newWord = newWord.Insert(0, first.ToString());
            newWord = newWord.Insert(newWord.Length, last.ToString()); 
            return newWord;
        }
    }

    public static String AddFrontAndBack(string str, char last)
    {
        string newWord = str;
        newWord = newWord.Insert(0, last.ToString());
        newWord = newWord.Insert(newWord.Length, last.ToString());
        return newWord;
    }
























    static String checkForOk(string str)
    {
        string newWord = "";

        
        for (int i=0; i < str.Length-1; i++){
            if (str[i] == 'o' && str[i+1]=='k' )
            {
                i++;
                continue;
            }
            newWord = newWord + str[i];
        }
        newWord += str[str.Length - 1];

        return newWord;
    }


    static void Main(string[] args)
    {
        string word = "Praokctiookkceko";
        int len = word.Length;
        /* string newWord =  Replace(word, word[len-1], word[0]);
          Console.Write(newWord);*/

        /*string NewWord = AddFrontAndBack(word, word[len - 1]);
        Console.Write(NewWord);*/
        string newWordOK = checkForOk(word);
        while (newWordOK.Contains("ok"))
        {
            newWordOK = checkForOk(newWordOK);
        }
        Console.WriteLine(newWordOK);
    }
}