/// Hangman Game with various difficulties that selects random word from array 
// Roughly 3 Hours to make due to being unable to find youtube video on how to replace character in string
//https://www.educative.io/answers/how-to-insert-one-string-into-another-using-insert-in-c-sharp
//https://www.educative.io/answers/how-to-remove-characters-from-a-string-using-remove-in-c-sharp

using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To The Hangman!");
            Console.WriteLine("\n");
            Random rand = new Random();
            int rndmNum = rand.Next(1, 5);
            int Lives = 6;
            string[] EasyWords = {" ","blitz", "lucky", "ivory", "cycle", "staff"};
            string[] MediumWords = {" ", "actress", "bangkok", "coroner", "dioxide", "interim"};
            string[] HardWords = {" ", "paparazzi", "blackjack", "zigzagged","flapjacks","essential",};
            string EasyBlank = "_____";
            string MediumBlank = "_______";
            string HardBlank = "_________";

            Console.WriteLine("\n");
            Console.WriteLine("\nPick A Number Corresponding To A Difficulty \n1-Easy / 2-Medium / 3-Hard");
            int diff = Convert.ToInt32(Console.ReadLine());

            if  (diff < 1 || diff > 3)
            {
                Console.WriteLine("Please Restart And Select A Number In The Range Corresponding To The Difficulty.");
                return;
            }

            if (diff == 1)
            {
                string Puzzle = EasyWords[rndmNum];
                Console.WriteLine("Welcome To The Easy Difficulty");
                Console.WriteLine("\n");
                Console.WriteLine("The Hidden Word Contains 5 Letters What Do You Think It Is :). ");
                Console.WriteLine("\n");
                Console.WriteLine(EasyBlank);
                
                while (Lives > 0){
                    if (Lives == 5){
                        Console.WriteLine("The Rope Has Appeared");
                    }if (Lives == 4){
                        Console.WriteLine("The Head Has Appeared");
                    }if (Lives == 3){
                        Console.WriteLine("The Torso Has Appeared");
                    }if (Lives == 2){
                        Console.WriteLine("The Legs Have Appeared");
                    }if (Lives == 1){
                        Console.WriteLine("The Arms Have Appeared");
                    }
                    Console.WriteLine("1 - Guess Word Or 2- Guess Letter");
                    int g1 = Convert.ToInt32(Console.ReadLine());
                    if (g1 == 1){
                        Console.WriteLine("Enter What You Think The Word Is, LowerCase Only");
                        string guess = Convert.ToString(Console.ReadLine());
                        if (guess == Puzzle)
                            {
                            Console.WriteLine("Congrats You Guessed The Answer with: " + Lives + " Lives Left");
                            break;
                            }
                        else
                        {
                            Lives--;
                            Console.WriteLine("Minus One Life, Try Again");
                        }
                    }

                    else if (g1 == 2){
                        Console.WriteLine("Enter What You Think The Letter Is, LowerCase Only");
                        char guess1 = Convert.ToChar(Console.ReadLine());
                        if (Puzzle.Contains(guess1))
                        {
                            Console.WriteLine("Well Done, You Guessed Correctly!");
                            int position = Puzzle.IndexOf(guess1);
                            EasyBlank = EasyBlank.Remove(position, 1);
                            EasyBlank = EasyBlank.Insert(position, guess1.ToString());
                            Console.WriteLine(EasyBlank);
                        }
                        else
                        {
                            Lives--;
                            Console.WriteLine("That Character Was Not Part Of The Answer, Minus One Life, Try Again");
                        }
                    } 
                } 
                if (Lives == 0){
                    Console.WriteLine("Try Again Better Luck Next Time");
                    return;
                }
            }

            if (diff == 2)
            {
                string Puzzle = MediumWords[rndmNum];
                Console.WriteLine("Welcome To The Medium Difficulty");
                Console.WriteLine("\n");
                Console.WriteLine("The Hidden Word Contains 7 Letters What Do You Think It Is :). ");
                Console.WriteLine("\n");
                Console.WriteLine(MediumBlank);
                
                while (Lives > 0){
                    if (Lives == 5){
                        Console.WriteLine("The Rope Has Appeared");
                    }if (Lives == 4){
                        Console.WriteLine("The Head Has Appeared");
                    }if (Lives == 3){
                        Console.WriteLine("The Torso Has Appeared");
                    }if (Lives == 2){
                        Console.WriteLine("The Legs Have Appeared");
                    }if (Lives == 1){
                        Console.WriteLine("The Arms Have Appeared");
                    }
                    Console.WriteLine("1 - Guess Word Or 2- Guess Letter");
                    int g1 = Convert.ToInt32(Console.ReadLine());
                    if (g1 == 1){
                        Console.WriteLine("Enter What You Think The Word Is, LowerCase Only");
                        string guess = Convert.ToString(Console.ReadLine());
                        if (guess == Puzzle)
                            {
                            Console.WriteLine("Congrats You Guessed The Answer with: " + Lives + " Lives Left");
                            break;
                            }
                        else
                        {
                            Lives--;
                            Console.WriteLine("Minus One Life, Try Again");
                        }
                    }

                    else if (g1 == 2){
                        Console.WriteLine("Enter What You Think The Letter Is, LowerCase Only");
                        char guess1 = Convert.ToChar(Console.ReadLine());
                        if (Puzzle.Contains(guess1))
                        {
                            Console.WriteLine("Well Done, You Guessed Correctly!");
                            int position = Puzzle.IndexOf(guess1);
                            MediumBlank = MediumBlank.Remove(position, 1);
                            MediumBlank = MediumBlank.Insert(position, guess1.ToString());
                            Console.WriteLine(MediumBlank);
                        }
                        else
                        {
                            Lives--;
                            Console.WriteLine("That Character Was Not Part Of The Answer, Minus One Life, Try Again");
                        }
                    } 
                } 
                if (Lives == 0){
                    Console.WriteLine("Try Again Better Luck Next Time");
                    return;
                }
            }

            if (diff == 3)
            {
                string Puzzle = HardWords[rndmNum];
                Console.WriteLine("Welcome To The Hard Difficulty");
                Console.WriteLine("\n");
                Console.WriteLine("The Hidden Word Contains 9 Letters What Do You Think It Is :). ");
                Console.WriteLine("\n");
                Console.WriteLine(HardBlank);
                
                while (Lives > 0){
                    if (Lives == 5){
                        Console.WriteLine("The Rope Has Appeared");
                    }if (Lives == 4){
                        Console.WriteLine("The Head Has Appeared");
                    }if (Lives == 3){
                        Console.WriteLine("The Torso Has Appeared");
                    }if (Lives == 2){
                        Console.WriteLine("The Legs Have Appeared");
                    }if (Lives == 1){
                        Console.WriteLine("The Arms Have Appeared");
                    }
                    Console.WriteLine("1 - Guess Word Or 2- Guess Letter");
                    int g1 = Convert.ToInt32(Console.ReadLine());
                    if (g1 == 1){
                        Console.WriteLine("Enter What You Think The Word Is, LowerCase Only");
                        string guess = Convert.ToString(Console.ReadLine());
                        if (guess == Puzzle)
                            {
                            Console.WriteLine("Congrats You Guessed The Answer with: " + Lives + " Lives Left");
                            break;
                            }
                        else
                        {
                            Lives--;
                            Console.WriteLine("Minus One Life, Try Again");
                        }
                    }

                    else if (g1 == 2){
                        Console.WriteLine("Enter What You Think The Letter Is, LowerCase Only");
                        char guess1 = Convert.ToChar(Console.ReadLine());
                        if (Puzzle.Contains(guess1))
                        {
                            Console.WriteLine("Well Done, You Guessed Correctly!");
                            int position = Puzzle.IndexOf(guess1);
                            HardBlank = HardBlank.Remove(position, 1);
                            HardBlank = HardBlank.Insert(position, guess1.ToString());
                            Console.WriteLine(HardBlank);
                        }
                        else
                        {
                            Lives--;
                            Console.WriteLine("That Character Was Not Part Of The Answer, Minus One Life, Try Again");
                        }
                    } 
                } 
                if (Lives == 0){
                    Console.WriteLine("Try Again Better Luck Next Time");
                    return;
                }
            }
        }
    }
}