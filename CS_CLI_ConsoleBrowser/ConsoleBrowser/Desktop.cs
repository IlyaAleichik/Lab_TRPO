using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleBrowser
{
    class Desktop 
    {
       
        FunctionsSystem fs = new FunctionsSystem();
        DateTime now = DateTime.Now;
        TextsBrowser tb = new TextsBrowser();
       


        public void Select_KeyBar()
        {

            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            if (keyPressed.Key == ConsoleKey.D2)
                {

                    fs.f_exit();

                }

                if (keyPressed.Key == ConsoleKey.D1)
                {
                    tb.Load_Browser();
                    Bar();

                }
           



        }
        public void Bar() {
            
            Console.Clear();
            Console.Write("| 1. TextBrowser | 2. Exit | Time: {0:T}   \n", now);
            Select_KeyBar();

        }
    
        public void  Starting_Desktop()
       {
            Console.Clear();
            Console.WriteLine("*************************************************************************\n" +
                              "*  Welcome. Console Browser Application Preview . Author: Ilya Alejchik *\n" +
                              "*  Version 1.0.0                                                        *\n" +
                              "*************************************************************************\n");
            Thread.Sleep(1000);
            Bar();
            Console.ReadLine();
            
       }

    }
}
