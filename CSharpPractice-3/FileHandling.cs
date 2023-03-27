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
            const string path = "D:\\C#\\CSharpPractice-3\\CSharpPractice-3\\fileInfo.txt";
            FileInfo fi = new FileInfo(path);
            fi.Create();
        }
    }
}
