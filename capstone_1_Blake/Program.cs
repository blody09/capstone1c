using System;

namespace capstone_1_Blake
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue = "y";


            while (userContinue != "n")
            {
                Console.WriteLine("Please type a sentence you want to have translated to pig latin.");
                string sentence = Console.ReadLine();
                var pigLatin = GetSentenceInPigLatin(sentence);
                Console.WriteLine(pigLatin);

                

                
                    //write lines to console from here
                   
               

                    userContinue = "";
                    while (userContinue != "y" && userContinue != "n")
                    {
                        Console.WriteLine("Would you like to do another translation, Y/N ?");
                        userContinue = Console.ReadLine().ToLower();

                    }
                
            }




        }

        private static string GetSentenceInPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeio";
            var returnSentence = "";
            foreach (var word in sentence.Split())
            {
                var firstLetter = word.Substring(0, 1).ToLower();
                var restOfWord = word.Substring(1, word.Length - 1).ToLower();
                var currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }
                else
                {
                    returnSentence += word + "way ";
                }
                
            }
            return returnSentence; 
        }
    }
  }
