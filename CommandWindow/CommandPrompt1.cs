using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommandWindow
{
    class CommandPrompt1
    {
        int height;
        int columns;
        string[] screenText;
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;

        public CommandPrompt1(int height, int columns, string[] screenText, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            this.height = height;
            this.columns = columns;
            this.screenText = screenText;
            this.backgroundColor = backgroundColor;
            this.foregroundColor = foregroundColor;
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }

        public CommandPrompt1(int height, int columns)
        {
            backgroundColor = ConsoleColor.Blue;
            foregroundColor = ConsoleColor.Red;
            // create the screen to hold the number of rows passed in with the height parameter
            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(columns, height + 7);

            // let's set the initial screen rows to all blank lines
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }   // end of CommandPrompt constructor

        internal void SetScreenText(int lineNum, string text)
        {
            throw new NotImplementedException();
        }

        internal void ClearScreen()
        {
            throw new NotImplementedException();
        }

        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }   // end of SetBackgroundColor

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }   // end of SetForegroundColor

        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {                 case "black": color = ConsoleColor.Black; break;
                case "red": color = ConsoleColor.Red; break;

                default: color = ConsoleColor.DarkGray; break;
            }
            return color;
        }   // end of ConvertColor method

        public void SaveScreen(string fileName)
        {
            StreamWriter textOut = null;
            try
            {
                fileName = "../../../" + fileName;
                textOut = new StreamWriter(fileName);
                //your code here!!!
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }   // End of SaveScreen method
    }
}
