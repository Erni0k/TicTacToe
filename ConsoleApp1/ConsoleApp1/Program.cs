﻿using System;
namespace TicTacToe
{
    class Program
    {
        static int[] board = { 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };
        static void Main(string[] args)
        {
            
            

            int User_1 = -1;
            int User_2 = -1;
            Random rand = new Random();
            int Win = 0;

            while (Win == 0)
            {
                try
                {
                    while (User_1 == -1 || board[User_1] != 0)
                    {
                        Console.WriteLine("1st player enter number from 1-8");
                        User_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("First player  typed:" + User_1);


                    }
                    Console.Clear();
                    board[User_1] = 1;
                    if (WinnerCheck() != 0)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    while (User_1 == -1 || board[User_1] != 0)
                    {
                        Console.WriteLine("1st player enter number from 1-8");
                        User_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("First player  typed:" + User_1);


                    }
                    Console.Clear();
                    board[User_1] = 1;
                    if (WinnerCheck() != 0)
                    {
                        break;
                    }
                }
                try
                {
                    printBoard();
                    while (User_2 == -1 || board[User_2] != 0)
                    {
                        Console.WriteLine("2nd player enter number from 1-8");
                        User_2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second player typed:" + User_2);


                    }
                    board[User_2] = 2;
                    if (WinnerCheck() != 0)
                    {
                        break;
                    }
                    Console.Clear();
                    printBoard();
                    Win = WinnerCheck();
                }
                catch (Exception ex)
                {
                    printBoard();
                    while (User_2 == -1 || board[User_2] != 0)
                    {
                        Console.WriteLine("2nd player enter number from 1-8");
                        User_2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second player typed:" + User_2);


                    }
                    board[User_2] = 2;
                    if (WinnerCheck() != 0)
                    {
                        break;
                    }
                    Console.Clear();
                    printBoard();
                    Win = WinnerCheck();
                }
            }
            printBoard();
            Console.WriteLine("Player " + WinnerCheck() + " " + "won the game!");
        }
        private static int WinnerCheck()
        {   //1st row
            if (board[1] == board[2] && board[2] == board[3])
            {
                return board[1];
            }
            //2nd row
            else if (board[4] == board[5] && board[5] == board[6])
            {
                return board[4];
            }
            //3rd row
            else if (board[7] == board[8] && board[8] == board[9])
            {
                return board[7];
            }
            //1st column
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }
            //2nd column
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }
            //3rd column
            else if (board[3] == board[6] && board[6] == board[9])
            {
                return board[3];
            }
            //1st diagonal
            else if (board[1] == board[5] && board[5] == board[9])
            {
                return board[1];
            }
            //2nd diagonal
            else if (board[3] == board[5] && board[5] == board[7])
            {
                return board[3];
            }

            return 0;
        }

        private static void printBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("X");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }
                if (i == 3 || i == 6 || i == 9)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}