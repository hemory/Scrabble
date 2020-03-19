using System;

namespace ScrabbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrabble point values
            string letter = "";
            switch (letter)
            {
                case "":
                    Console.WriteLine("Zero Points");
                    break;
                case "e":
                case "a":
                case "i":
                case "o":
                case "n":
                case "t":
                case "l":
                case "s":
                case "u":
                case "r":
                    Console.WriteLine("One point");
                    break;
                case "d":
                case "g":
                    Console.WriteLine("2 points");
                    break;
                case "b":
                case "c":
                case "m":
                case "p":
                    Console.WriteLine("3 points");
                    break;

                case "f":
                case "h":
                case "v":
                case "w":
                case "y":
                    Console.WriteLine("4 points");
                    break;
                case "k":
                    Console.WriteLine("5 points");
                    break;
                case "j":
                case "x":
                    Console.WriteLine("8 points");
                    break;
                case "q":
                case "z":
                    Console.WriteLine("10 points");
                    break;
            }
        }
    }
