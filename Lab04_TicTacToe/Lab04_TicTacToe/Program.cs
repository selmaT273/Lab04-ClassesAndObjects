using Lab04_TicTacToe.Classes;
using System;
using System.Security.Cryptography;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*~~*~~Welcome to the Wild World of TicTacToe!~~*~~*");
            Console.ReadLine();
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.

            Console.Clear();
            Console.WriteLine("What is Player One's name?");
            Player PlayerOne = new Player() { Name = Console.ReadLine() };
            Console.Clear();
            Console.WriteLine("What is Player Two's name?");
            Player PlayerTwo = new Player() { Name = Console.ReadLine() };

            Game game = new Game(PlayerOne, PlayerTwo);
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }


    }
}
