using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Daniel Williams 266698
namespace testAssignment
{
    class Program
    {        
        static void Main(string[] args)
        {
            TextDocInput textDoc = new TextDocInput(); 
            UserEntry userEnt = new UserEntry(); 
            
            string usersChoice;                     //holds choice inputted by the user
            int errorLoop = 1;                      //holds value of error loop
            int programLoop = 1;                    //holds value of program loop

            while (programLoop <= 1)                //loop that executes if the loop value is less than or equal to 1
            {
                try
                {
                    do
                    {
                        Console.WriteLine("\nPlease select an option\n1: Input from Keyboard\n2: Input from Text file\nQ: Quit");
                        usersChoice = Console.ReadLine();                            //takes in and stores users choice

                        if (usersChoice == "1")                                      //executed if user enters 1
                        {
                            errorLoop = errorLoop + 1;                               //adds one to error loop, stopping the loop from executing 
                            userEnt.UserTextEntry();                                 //calls userTextEntry method                     
                        }
                        else
                        {
                            if (usersChoice == "2")                                  //executed if users enters  2
                            {
                                errorLoop = errorLoop + 1;                           //adds 1 to error loop
                                Console.WriteLine("\nYou have chosen option 2\n");   //output
                                textDoc.TextFile();                                  //calls TextFile method
                            }
                            else
                            {
                                if (usersChoice == "Q" || usersChoice == "q")        //executed if user enters 
                                {                                    
                                    programLoop = programLoop + 1;
                                    System.Environment.Exit(0);                      //closes program and debug window
                                    
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid Input! Please try again...");   //output is user enters wrong value
                                }
                            }
                        }
                    } while (errorLoop <= 1);                                                    //executed if user does not enter a valid input
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invlid Input! Please try again");                         //Outptted when error is format error is found
                }

                Console.ReadKey();                                                               //waits for user
            }
        }     
    }
}
