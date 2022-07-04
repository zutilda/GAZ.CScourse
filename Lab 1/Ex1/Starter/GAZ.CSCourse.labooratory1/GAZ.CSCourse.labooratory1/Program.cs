using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GAZ.CSCourse.labooratory1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line;
            string allText = "";         
            StreamReader f = new StreamReader("DataFile.txt");
            while (!f.EndOfStream)
            {
                line = f.ReadLine();
                line = line.Replace(",", " y:");
                line = "x:" + line;
                allText += line;
            }
            f.Close();
            StreamWriter d = new StreamWriter("DataFile.txt");
            d.Write(allText);
           
            d.Close();
        }
    }
}
