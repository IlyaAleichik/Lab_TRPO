using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBrowser
{
    
    class FunctionsSystem 
    {
        
        public void f_exit() {
      
            Desktop ds = new Desktop();
            char key = 'y';
           
            Console.WriteLine("\n****************************************\n" +
                              "**         Желаете выйти!  y/n        **\n" +
                              "****************************************\n");
            try { 
            key = Convert.ToChar(Console.ReadLine());
            if (key == 'y') { Environment.Exit(0); }
            else { ds.Starting_Desktop(); } }
            catch { Console.Write(" Неправильный формат комманды! ");}


        }
        public void Menu()
        {



        }
        public void Command_String()
        {
            Console.Clear();
            Console.WriteLine("\n Programm Console String:  \n");

            string str = Console.ReadLine();

        }
      

    }
}
