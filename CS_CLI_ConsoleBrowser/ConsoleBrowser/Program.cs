using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleBrowser
{
    class Program
    {
        static void Init_Color() {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
           
        }
        static void Main(string[] args)
        {

            Init_Color();
            Desktop desktop = new Desktop();
            desktop.Starting_Desktop();
        }




    }
}
