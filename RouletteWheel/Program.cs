using System;
using System.Collections.Generic;
using System.Threading;
using RouletteWheel;

namespace RouletteWheel
{
    public class Program
    {

        static int money;
        static Random rnd = new Random();
        static Color landingColor;
        static int landingInt;

        
        static void Main(string[] args)
        {
            Bets.SplitPossibilities(out Bets.splits);
            Title();
            Money(out money);
            GetBets(amtBets());
            WheelSpin(out landingColor, out landingInt);
        }
        static string Character() => "Croupier";
        static void Title()
        {
            string title =

                @" ________  ________  ___  ___  ___       _______  _________  _________  _______      " + "\n" +
                @"|\   __  \|\   __  \|\  \|\  \|\  \     |\  ___ \|\___   ___\\___   ___\\  ___ \     " + "\n" +
                @"\ \  \|\  \ \  \|\  \ \  \\\  \ \  \    \ \   __/\|___ \  \_\|___ \  \_\ \   __/|    " + "\n" +
                @" \ \   _  _\ \  \\\  \ \  \\\  \ \  \    \ \  \_|/__  \ \  \     \ \  \ \ \  \_|/__  " + "\n" +
                @"  \ \  \\  \\ \  \\\  \ \  \\\  \ \  \____\ \  \_|\ \  \ \  \     \ \  \ \ \  \_|\ \ " + "\n" +
                @"   \ \__\\ _\\ \_______\ \_______\ \_______\ \_______\  \ \__\     \ \__\ \ \_______\" + "\n" +
                @"    \|__|\|__|\|_______|\|_______|\|_______|\|_______|   \|__|      \|__|  \|_______|"
            ;
            Console.WriteLine(title);
        }
        static void Money(out int money)
        {
            Console.WriteLine($"{Character()} : How much did ya bring to the table?");
            bool valid;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out money);
            } while (!valid);
            if (money == 0)
            {
                Console.WriteLine("Well ya got no money :(");
                Thread.Sleep(700);
                exitGame();
            }

            Thread.Sleep(1000);
            Console.WriteLine($"{Character()} : Awesome, you have ${money}, let's play.");
        }
        static int amtBets()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{Character()} : How many bets are ya makin?");
            bool valid;
            int amtbets;
            do
            {
                valid = int.TryParse(Console.ReadLine(), out amtbets);
                if (amtbets < 0)
                {
                    Console.WriteLine("invalid input");
                    valid = false;
                }
            } while (!valid);

            Thread.Sleep(1000);
            Console.WriteLine($"{Character()} : {amtbets} times huh?");
            Thread.Sleep(1000);
            Console.WriteLine($"{Character()} : well good luck!");
            return amtbets;
        }
        static int GetBets(int amtBets)
        {
            bool valid;
            int group = 1;
            int getBets = 0;
            List<int[]> bet = new List<int[]>();
            try
            {

                Thread.Sleep(1000);
                Console.WriteLine($"{Character()} : what type of bet do you wanna make?");
                listtypesOfBets();

                for (int i = 0; i < amtBets; i++)
                {
                    do
                    {
                        Console.Write($"Bet {i + 1}:");
                        valid = int.TryParse(Console.ReadLine(), out getBets);
                        if (getBets <=0 || getBets > 13)
                        {

                            Console.WriteLine("Invalid Input");
                            valid = false;
                        }

                    } while (!valid);
                    switch (getBets)
                    {
                        case 1:
                            Console.WriteLine("What number are you betting on?");
                            Console.WriteLine("To bet on 'Green 00' type 37");
                            int[] chosenNumberToPass = new int[1];
                            int chosenNumber = 1;
                            do
                            {
                                int.TryParse(Console.ReadLine(), out chosenNumber);
                                if (chosenNumber <= 0 || chosenNumber > 37)
                                {
                                    Console.WriteLine("Invalid Number try again");
                                }
                            }
                            while (chosenNumber <=0 || chosenNumber > 37);
                            chosenNumberToPass[0] = chosenNumber;
                            bet.Add(chosenNumberToPass);
                            break;
                        case 2:
                            Console.WriteLine($"{Character()}{Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            bet.Add(Bets.evens);
                            break;
                        case 3:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            bet.Add(Bets.odds);
                            break;
                        case 4:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            bet.Add(Bets.reds);
                            break;
                        case 5:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            bet.Add(Bets.blacks);
                            break;
                        case 6:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");

                            bet.Add(Bets.lows);
                            break;
                        case 7:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");

                            bet.Add(Bets.highs);
                            break;
                        case 8:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            Console.WriteLine($"{Character()} : Choose a group to bet on!");
                            for (int j = 0; j < Bets.dozens.GetLength(0); j++)
                            {
                                Console.WriteLine($"Group : {j + 1}");
                                for (int k = 0; k < Bets.dozens.GetLength(1); k++)
                                {
                                    Console.Write($"{Bets.dozens[j, k]}|");
                                }
                                Console.Write($"\n");
                                chosenNumber = 1;
                                do
                                {
                                    int.TryParse(Console.ReadLine(), out chosenNumber);
                                    if (chosenNumber <= 0 || chosenNumber > 37)
                                    {
                                        Console.WriteLine("Invalid Number try again");
                                    }
                                }
                                while (chosenNumber <= 0 || chosenNumber > Bets.dozens.GetLength(0));
                                
                            }
                            bet.Add(Bets.dozens);
                            break;
                        case 9:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            break;
                        case 10:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            break;
                        case 11:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            break;
                        case 12:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            break;
                        case 13:
                            Console.WriteLine($"{Character()} : {Enum.GetNames(typeof(TypesOfBets))[getBets-1]} it is!");
                            break;
                        default:
                            break;
                    }

                }
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
            
            return getBets;
        }
        static void listtypesOfBets()
        {
            int count = 1;
            foreach (TypesOfBets types in Enum.GetValues(typeof(TypesOfBets)))
            {
                Console.Write($"{count}: {types} ");
                if (count == 8)
                {
                    Console.WriteLine("");
                }
                count++;
            }
            Console.WriteLine("");
        }
        static void WheelSpin(out Color landingColor,out int landingNumber)
        {
            Console.WriteLine("Press enter to spin wheel");
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                Console.WriteLine("Wheel is spinning...");
            }
            while (keyinfo.Key != ConsoleKey.Enter);

            Wheel wheel = new Wheel();
            Thread.Sleep(1500);
            landingColor = wheel.RandomPiece.color;
            landingNumber = wheel.RandomPiece.number;
            Console.WriteLine($"The ball landed on {landingNumber} {landingColor}");
        }
        static void exitGame()
        {
            Console.WriteLine("Thanks for playing!");
            Thread.Sleep(500);
            Console.WriteLine("Press anything to exit");
            Console.ReadKey();
            Environment.Exit(0);
            //ConsoleKeyInfo keypress;
            //bool valid = false;
            //while (valid)
            //{
            //    keypress = Console.ReadKey();
            //    if (keypress.Key == ConsoleKey.Enter)
            //    {
            //        Environment.Exit(0);
            //    }
            //}
        }
    }
}
