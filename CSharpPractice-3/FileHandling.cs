using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice_3
{
    internal class FileHandling
    {
        public FileHandling()
        {
            FileStream file = new FileStream("D:\\C#\\CSharpPractice-3\\CSharpPractice-3\\file1.txt", FileMode.OpenOrCreate);
            StreamWriter pen = new StreamWriter(file);
            pen.Write("Written from file writer");
            pen.Close();
            file = new FileStream("D:\\C#\\CSharpPractice-3\\CSharpPractice-3\\file1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(file);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            sr.Close();
            file.Close();
        }
    }
}
