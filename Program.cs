using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Tracing;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome To Hangman! ");

            //string word1 = "Stege";
            //string word2 = "Hus";
            //string word3 = "Björnunge";
            string[] words = { "Ladder", "House", "Bear" };
            Random random = new Random();
            int rnd = random.Next(words.Length);
            string secretWord = words[rnd];
            string guessString = new string('_', secretWord.Length);
            StringBuilder guessBuilder = new StringBuilder(guessString);

            // loop över gissningar
            for (int j = 0; j<5; j++)
            {
                Console.Write("Guess a letter: ");
                string wordGuess = Console.ReadLine();



                bool correctLetterGuess = false;
                bool correctWordGuess = false;

                StringBuilder Sb1 = new StringBuilder();
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == wordGuess[0])
                    {
                        Sb1.Append(secretWord[i] + " ");
                        guessBuilder[i] = secretWord[i];
                        correctLetterGuess = true;
                    }
                    else
                    {
                        Sb1.Append("_ ");
                    }
                    // if (guessBuilder == secretWord)
                    //    correctWordGuess
                }
                Console.WriteLine(guessBuilder);

                if (correctWordGuess)
                    Console.WriteLine("Ordet är rätt");
                else
                    Console.WriteLine("Ordet är inte rätt");

                if (correctLetterGuess)
                    Console.WriteLine("Bokstaven är rätt");
                else
                    Console.WriteLine("Bokstaven är inte rätt");

            }
            

            //if (wordGuess == secretWord)
            //{
            //    Console.WriteLine("Grattis du gissade rätt, ordet var" + " " + secretWord);
            //} 
            //if (wordGuess != secretWord)
            //{
            //    Console.WriteLine("Du gissade fel,  ordet var" + " " + secretWord);
            //}








        }
    }
}