using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Daniel Williams 266698
namespace testAssignment
{
    class Analysis
    {
        //counters
        private int counter, counterB, counterC, counterD, counterE, counterF, counterG, counterH, counterI, counterJ, counterK,
            counterL, counterM, counterN, counterO, counterP, counterQ, counterR, counterS, counterT, counterU, counterV, counterW,
            counterX, counterY, counterZ;  
        
        /// <summary>
        /// Takes in users input and checks each character to see if it is in the array. If the character 
        /// does exist in the array 1 is added to the counter. This method counts the number of vowels used by the user.
        /// </summary>
        /// <param name="usersInput"></param>
        public void vowelCount(string usersInput)
        {
            counter = 0;

            char[] vowels = new char[10] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };     //Array to hold vowel characters
            
            foreach(char c in usersInput)                                                          //checking each character in the input
            {
                if(vowels.Contains(c))                                                             
                {
                    counter = counter + 1;                                                         //adds 1 to the counter if a vowel is found
                }
            }

            Console.WriteLine("\nVowels:\t\t\t {0}", counter);
        }

        /// <summary>
        /// Takes in users input and checks each character to see if it is in the array. If the character 
        /// does exist in the array 1 is added to the counter. This method counts the number of consonants used in the users input. 
        /// </summary>
        /// <param name="usersInput"></param>
        public void ConsonantCount(string usersInput)
        {
            counter = 0;

            char[] consonants = new char[42] {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z','B','C',
                'D','F','G','H','J','K','L','M','N','P','Q','R','S','T','V','W','X','Y','Z'};                                                     //array holding consontant characters

            foreach (char c in usersInput)                                                                                                        //cheching each character in the input
            {
                if (consonants.Contains(c))
                {
                    counter = counter + 1;                                                                                                        //adds 1 to the counter if consonant is found
                }
            }

            Console.WriteLine("Consonants: \t\t {0}", counter);
        }

        /// <summary>
        /// Takes in users input and checks each character to see if it is in the array. If the character 
        /// does exist in the array 1 is added to the counter. This method counts the number of lower case characters used.
        /// </summary>
        /// <param name="userInput"></param>
        public void LowerCount(string userInput)
        {
            counter = 0;

            char[] lowerCase = new char[26] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u',
                'v','w','x','y','z'};                                                                                                       //array holding lower case characters

            foreach (char c in userInput)                                                                                                   //checks each character of the input
            {
                if (lowerCase.Contains(c))
                {
                    counter = counter + 1;                                                                                                  //add 1 to the counter if a lower case character is found
                }
            }

            Console.WriteLine("Lower Case Characters:\t {0}",counter);
        }
        
        /// <summary>
        /// Takes in users input and checks each character to see if it is in the array. If the character 
        /// does exist in the array 1 is added to the counter. This method count the number of upper case characters.
        /// </summary>
        /// <param name="userInput"></param>
        public void UpperCount(string userInput)
        {            
            counter = 0;

            char[] upper = new char[26] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W',
                'X','Y','Z'};                                                                                                               //array holding upper case characters

            foreach (char c in userInput)                                                                                                   //checks each character of the input
            {
                if(upper.Contains(c))
                {
                    counter = counter + 1;                                                                                                  //adds 1 to the counter if an upper case character is found
                }
            }

            Console.WriteLine("Upper Case Characters:\t {0}", counter);           
        }

        /// <summary>
        /// Takes in users input and checks each character to see if it is in the array. If the character 
        /// does exist in the array 1 is added to the counter. This method counts the sentences used by the user.
        /// </summary>
        /// <param name="userInput"></param>
        public void SentenceCount(string userInput)
        {
            counter = 0;

            char[] sentence = new char[3] { '.', '?', '!' };        //array holding characters that signify the end of a sentence

            foreach (char c in userInput)                           //checks each character of the input
            {
                if (sentence.Contains(c))
                {
                    counter = counter + 1;                          //adds 1 to the counter if a specified character is found
                }
            }

            Console.WriteLine("Sentences:\t\t {0}", counter);            
        }

        /// <summary>
        /// Takes in users input and checks each character to see if it is in the array. If the character 
        /// does exist in the array 1 is added to the counter. This methods counts the frequency of each character.
        /// </summary>
        /// <param name="userInput"></param>
        public void Letterfrequency(string userInput)
        {
            counter = 0;
            
            char[] letterFrequency = new char[52] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 
                'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W', 'X','Y','Z' };                                                                                                 //array holding the characters og the alphabet

            foreach (char c in userInput)                                                                                                       //checks each character of the input
            {
                if (c == letterFrequency.ElementAt(0) || c == letterFrequency.ElementAt(26))
                {
                    counter = counter + 1;                                                                                                      //adds 1 to the counter if the specified letter is found
                }
                                
                if (c == letterFrequency.ElementAt(1) || c == letterFrequency.ElementAt(27))
                {
                counterB = counterB + 1;                                                                                                        
                }
                    
                if (c == letterFrequency.ElementAt(2) || c == letterFrequency.ElementAt(28))
                {
                counterC = counterC + 1;
                }
                        
                if (c == letterFrequency.ElementAt(3) || c == letterFrequency.ElementAt(29))
                {
                counterD = counterD + 1;
                }
                            
                if (c == letterFrequency.ElementAt(4) || c == letterFrequency.ElementAt(30))
                {
                counterE = counterE + 1;
                }
                                
                if (c == letterFrequency.ElementAt(5) || c == letterFrequency.ElementAt(31))
                {
                counterF = counterF + 1;
                }
                                    
                if (c == letterFrequency.ElementAt(6) || c == letterFrequency.ElementAt(32))
                {
                counterG = counterG + 1;
                }
                                        
                if (c == letterFrequency.ElementAt(7) || c == letterFrequency.ElementAt(33))
                {
                counterH = counterH + 1;
                }

                if (c == letterFrequency.ElementAt(8) || c == letterFrequency.ElementAt(34))
                {
                    counterI = counterI + 1;
                }

                if (c == letterFrequency.ElementAt(9) || c == letterFrequency.ElementAt(35))
                {
                    counterJ = counterJ + 1;
                }

                if (c == letterFrequency.ElementAt(10) || c == letterFrequency.ElementAt(36))
                {
                    counterK = counterK + 1;
                }

                if (c == letterFrequency.ElementAt(11) || c == letterFrequency.ElementAt(37))
                {
                    counterL = counterL + 1;
                }

                if (c == letterFrequency.ElementAt(12) || c == letterFrequency.ElementAt(38))
                {
                    counterM = counterM + 1;
                }

                if (c == letterFrequency.ElementAt(13) || c == letterFrequency.ElementAt(39))
                {
                    counterN = counterN + 1;
                }

                if (c == letterFrequency.ElementAt(14) || c == letterFrequency.ElementAt(40))
                {
                    counterO = counterO + 1;
                }

                if (c == letterFrequency.ElementAt(15) || c == letterFrequency.ElementAt(41))
                {
                    counterP = counterP + 1;
                }

                if (c == letterFrequency.ElementAt(16) || c == letterFrequency.ElementAt(42))
                {
                    counterQ = counterQ + 1;
                }

                if (c == letterFrequency.ElementAt(17) || c == letterFrequency.ElementAt(43))
                {
                    counterR = counterR + 1;
                }

                if (c == letterFrequency.ElementAt(18) || c == letterFrequency.ElementAt(44))
                {
                    counterS = counterS + 1;
                }

                if (c == letterFrequency.ElementAt(19) || c == letterFrequency.ElementAt(45))
                {
                    counterT = counterT + 1;
                }

                if (c == letterFrequency.ElementAt(20) || c == letterFrequency.ElementAt(46))
                {
                    counterU = counterU + 1;
                }

                if (c == letterFrequency.ElementAt(21) || c == letterFrequency.ElementAt(47))
                {
                    counterV = counterV + 1;
                }

                if (c == letterFrequency.ElementAt(22) || c == letterFrequency.ElementAt(48))
                {
                    counterW = counterW + 1;
                }

                if (c == letterFrequency.ElementAt(23) || c == letterFrequency.ElementAt(49))
                {
                    counterX = counterX + 1;
                }

                if (c == letterFrequency.ElementAt(24) || c == letterFrequency.ElementAt(50))
                {
                    counterY = counterY + 1;
                }

                if (c == letterFrequency.ElementAt(25) || c == letterFrequency.ElementAt(51))
                {
                    counterZ = counterZ + 1;
                }
            }

            Console.WriteLine("\nLetter Frequency:\nA: {0}\nB: {1}\nC: {2}\nD: {3}\nE: {4}\nF: {5}\nG: {6}\nH: {7}\nI: {8}\nJ: {9}\nK: {10}" +
            "\nL: {11}\nM: {12}\nN: {13}\nO: {14}\nP: {15}\nQ: {16}\nR: {17}\nS: {18}\nT: {19}\nU: {20}\nV: {21}\nW: {22}\nX: {23}\nY: {24}\nZ: {25}",
            counter, counterB, counterC, counterD, counterE, counterF, counterG, counterH, counterI, counterJ, counterK, counterL, counterM,
            counterN, counterO, counterP, counterQ, counterR, counterS, counterT, counterU, counterV, counterW, counterX, counterY, counterZ);
        }
    }
}
