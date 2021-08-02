using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Interpret_Command
{
    class Entry
    {
        
   
        static public void Login()
        {
            Entry en = new Entry();
             
            en.getChar();
            Console.ReadKey();
        }

        public void getChar() {

            int count = -1;
            
            string s = "";
            string login = "";


            Console.Write("Login :");  login = Console.ReadLine();


            while (true)
            {
                count++;
                if (count == 8)
                {
                    char Otv = 'n';
                    Console.WriteLine(" Пароль может состоять из 8 символов! \n");

                    Console.WriteLine("Выйти? y/n ");
                    Otv = Convert.ToChar(Console.ReadLine());
                    if (Otv == 'y')
                    {

                        break;
                    }
                    else {  }
                }
                ConsoleKeyInfo c = Console.ReadKey();  
                if (c.Key == ConsoleKey.Enter)
                    break;
                Console.Clear();


                Console.Write("Password: ");
                if (c.Key == ConsoleKey.Backspace)
                {
                    if (s.Length > 0)
                        s = s.Remove(s.Length - 1);
                }
                else
                    s += c.KeyChar;
                foreach (char ch in s)
                    Console.Write('*');
             
            }
            using (FileStream fstream = new FileStream("entry.txt", FileMode.OpenOrCreate)) {

                byte[] array = System.Text.Encoding.Default.GetBytes(s);
              
                fstream.Write(array, 0, array.Length);

            }
            
        }

    }
}
