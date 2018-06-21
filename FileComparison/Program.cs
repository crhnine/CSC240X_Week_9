using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileComparison
{
    class Program
    {
        static void Main(string[] args)
        {


            FileInfo fileInfo = new FileInfo(@"C:\Users\chris\OneDrive\Desktop\Week 9 Assignments\movie_quote.txt");
            long s1 = fileInfo.Length;
            Console.WriteLine(s1.ToString());

            FileInfo fileInfo2 = new FileInfo(@"C:\Users\chris\OneDrive\Desktop\Week 9 Assignments\movie_quote.docx");
            long s2 = fileInfo.Length;
            Console.WriteLine(s2.ToString());



        }
    }
}
