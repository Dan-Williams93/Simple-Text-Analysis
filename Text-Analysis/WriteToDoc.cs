using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace testAssignment
{
    class WriteToDoc
    {
        private string writeFile = @"H:\writeFile.txt";                                                //holds location of write to file
        private string longWords = "";                                                                 //holds list of words with 7 ormore characters

        public void LongWords(string text)
        {
            string[] words = text.Split(' ', '.', '*', '?', '!', '"', ',', ':', ';', '(', ')', '\'', '\r', '\n', '\t' ); //splits tect file at specified symbol and stored each word in an array

            foreach (string w in words)                                                                                  //executed for each word stored in the words array
            {
                if (w.Length >= 7)                                                                                       //executed if word has 7 or more characters
                {
                    longWords = longWords + " " + w;                                                                     //adds the word to the lonwords variable
                }
            }


            //writes to file on new line
            string[] longArray = longWords.Split(' ');                                                 //splits the longwords string at whitespace and stores the words in an array
            File.WriteAllLines(writeFile, longArray);                                                  //writes the array to the write text file*/
        }

    }
}
