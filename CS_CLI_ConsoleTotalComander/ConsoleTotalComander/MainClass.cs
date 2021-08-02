using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleTotalComander
{
    class MainClass
    {

       public void catalog() {


            string dirName = "C:\\";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                   
                }
                Console.WriteLine();
             
            }
            Console.Read();
        }
   
       
    }
}
