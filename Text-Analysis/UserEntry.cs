using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Daniel Williams 266698
namespace testAssignment
{
    class UserEntry
    {
        Analysis textAn = new Analysis(); 
        WriteToDoc wtd = new WriteToDoc();
        private string userText;             //holds users final input
        private string text;                 //holds users input
        private int textLoop = 1;            //holds value for input loop

        public void UserTextEntry()
        {
            textLoop = 1; //sets text loop back to 1
            userText = "";
            text = "";

            Console.WriteLine("\nYou have chosen option 1.\nPlease input you text and finish your last sentence with *"); //output to the user
            
            while (textLoop <= 1)                           //loop executed if loop is less than or equal to 1
            {
                text = Console.ReadLine();                  //takes in users input ans stores in text variable
                userText += (" " + text);                   //adds users input to the final usersText variable

                foreach (char c in userText)                //executed for each character of the users input
                {
                    if (c == '*')                           //executed if the character is a *
                    {
                        textLoop = textLoop + 1;            //adds 1 to the text loop stopping it from executing
                    }
                }
            }

            textAn.vowelCount(userText);                    //calls vowel count method from analysis and passes users text
            textAn.ConsonantCount(userText);                //calls consonant count method from analysis and passes users text
            textAn.LowerCount(userText);                    //calls vowel lower case method from analysis and passes users text
            textAn.UpperCount(userText);                    //calls upper case count method from analysis and passes users text
            textAn.SentenceCount(userText);                 //calls sentence count method from analysis and passes users text
            textAn.Letterfrequency(userText);               //calls letter frequency method from analysis object and passes users text
            wtd.LongWords(userText);                        //calls LongWords method from wtd object and passes users text

        }
    }
}
