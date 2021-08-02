using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
namespace ConsoleBrowser
{
    class TextsBrowser
    {
       
        public string applicationName = "Текстовый браузер";
        public string versionNumber = "Version 1.0";
        bool debugMode = false;

        string URL = "https://habrahabr.ru/";
        string pageTitle = "Пустая страница";
   
        string source = string.Empty;
        bool pageLoaded = false;
      
        string regexBetweenTags = ">(.*?)<";
        string regexTags = "<(.*?)>";

        bool inBody = false;
        bool inTitle = false;
        bool inHiddenSection = false;
        public void Load_Browser()
        {

            Main();

        }
        private void Main()
        {
            Desktop desk = new Desktop();
           
                drawBrowser();

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                if (keyPressed.Key == ConsoleKey.Escape)
                {

                    desk.Bar();
                }

                if (keyPressed.Key == ConsoleKey.F2)
                {
                    
                    URL = "                                                      ";
                    drawURLfield();
                    Console.SetCursorPosition(5, 2);
                    URL = Console.ReadLine();
                    pageLoaded = false;
                }
          

        }

        #region Menu
        private enum menuItems
        { 
            
            F2_Поиск,
            Esc_Выйти,
            END,
        }

        private void drawMenu()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(applicationName + " " + versionNumber + " \n " + pageTitle);
            for (int i = 0; i < (int)menuItems.END; i++)
            {
                Console.Write(" | " + (menuItems)i);
            }
            Console.Write(" |");
        }
        #endregion

        #region PageLoad

        private string fetchWebPage()
        {
            pageLoaded = true;
            WebRequest r = WebRequest.Create(URL);
            WebResponse resp = r.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd();
        }

        #endregion

        #region draw
        private void drawBrowser()
        {
            Console.Clear();
            drawMenu();
            drawURLfield();
            if (!pageLoaded) source = fetchWebPage();
            drawPage(source);
            drawMenu();
        }

        private void drawPage(string source)
        {
            MatchCollection betweenTagMatches = Regex.Matches(source, regexBetweenTags);
            MatchCollection tagMatches = Regex.Matches(source, regexTags);

            int lastBetweenIndex = betweenTagMatches[betweenTagMatches.Count - 1].Index;
            int lastTagIndex = tagMatches[tagMatches.Count - 1].Index;

            int currentBetweenTag = 0;
            int currentTag = 0;

            for (int i = 0; i < Math.Max(lastBetweenIndex, lastTagIndex); i++)
            {
                if (currentBetweenTag < betweenTagMatches.Count)
                {
                    if (betweenTagMatches[currentBetweenTag].Index == i)
                    {
                        string line = betweenTagMatches[currentBetweenTag].Value;
                        line = line.Trim('>', '<');
                        if (line.Length > 0)
                        {
                            if (inBody && !inHiddenSection) Console.Write(line);
                            else if (inTitle) pageTitle = line;
                        }
                        currentBetweenTag++;
                    }
                }

                if (currentTag < tagMatches.Count)
                {
                    if (tagMatches[currentTag].Index == i)
                    {
                        string line = tagMatches[currentTag].Value;

                        if (!processTag(line, tagMatches[currentTag].Index))
                        {
                            if (debugMode && line.Length > 0)
                                Console.WriteLine(line);
                        }
                        currentTag++;
                    }
                }

            }

        }

        private void drawURLfield()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("URL: " + URL);
        }

        #endregion

        private bool processTag(string tag, int index)
        {
            string tagStart = tag.Trim(' ');
            tagStart = tag.Split(' ', '>')[0];
            
            switch (tagStart)
            {
               
                case "<body":            
                    inBody = true;
                    break;
                case "</body":
                    inBody = false;
                    break;

                case "<title":
                    inTitle = true;
                    break;
                case "</title":
                    inTitle = false;
                    break;

                case "<h1":
                case "<h2":
                case "<h3":

             
                    break;
                case "</h1":
                case "</h2":
                case "</h3":
                case "</h4":
                   
                    Console.WriteLine();
                    break;

                case "<a":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    break;
                case "</a":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "<br":
                case "</p":
                    Console.WriteLine();
                    break;

                case "<script":
               
                case "<style":
                   
                    inHiddenSection = true;
                    break;
                case "</script":
               
                case "</style":
                   
                    inHiddenSection = false;
                    break;

                default:
                    return false;
            }
            return true;
        }



      
      
       
    }
}
