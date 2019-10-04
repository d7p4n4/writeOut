using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace writeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a string with a line of text.
            string text = "First line" + Environment.NewLine;

            // Write the text to a new file named "WriteFile.txt".
            File.WriteAllText(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName), text);
            /*
            // Create a string array with the additional lines of text
            string[] lines = { "New line 1", "New line 2" };

            // Append new lines of text to the file
            File.AppendAllLines("D:/Server/writeLines.txt", lines);
           */

            Console.WriteLine(File.Exists("D:/Server/writeFile.txt"));
        }
    }
}
