using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Daniel Williams 266698
namespace testAssignment
{
    class TextDocInput
    {
        private static string file = @"TextFileInput.txt";
        private string text = File.ReadAllText(file);           //reads text file into program
              
        public void TextFile()
        {
            Analysis txtAn = new Analysis();                    //creates a new object of analysis
            WriteToDoc wtd = new WriteToDoc();                  
            
            Console.WriteLine("{0}", text);                     //outputs text file to the console

            //Calls all analysis methods passing text to each
            txtAn.vowelCount(text); 
            txtAn.ConsonantCount(text); 
            txtAn.LowerCount(text); 
            txtAn.UpperCount(text); 
            txtAn.SentenceCount(text); 
            wtd.LongWords(text); 
            txtAn.Letterfrequency(text);
        }
    }
}

         