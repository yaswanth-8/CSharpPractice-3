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
    static void Main(string[] args)
    {
        string word = "Practice";
        int len = word.Length;
       string newWord =  Replace("Practice", word[len-1], word[0]);
        Console.Write(newWord);
    }
}