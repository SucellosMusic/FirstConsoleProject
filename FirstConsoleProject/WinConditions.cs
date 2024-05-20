using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace FirstConsoleProject
{
    public class WinConditions
    {
        private char[] rowD1 = new char[4];
        private char[] rowD2 = new char[4];
        private char[] rowC1 = new char[4];
        private char[] rowC2 = new char[4];
        private char[] rowB1 = new char[4];
        private char[] rowB2 = new char[4];
        private char[] rowA1 = new char[4];
        private char[] rowA2 = new char[4];
        private char[] col1 = new char[4];
        private char[] col2 = new char[4];
        private char[] col3 = new char[4];
        private char[] col4 = new char[4];
        private char[] col5 = new char[4];
        private char[] diag1 = new char[4];
        private char[] diag2 = new char[4];
        private char[] diag3 = new char[4];
        private char[] diag4 = new char[4];

        public void fill_win_conditions(Array board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i == 3 && j > 0 && j < 5)
                    {
                        rowD1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 1)
                        {
                            diag3[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col1[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 2)
                        {
                            diag4[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            col2[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 3)
                        {
                            col3[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 4)
                        {
                            diag1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col4[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 3 && j > 1)
                    {
                        rowD2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 5)
                        {
                            diag2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            col5[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 2 && j > 0 && j < 5)
                    {
                        rowC1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 1)
                        {
                            col1[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 2)
                        {
                            diag3[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col2[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 3)
                        {
                            diag1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            diag4[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            col3[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 4)
                        {
                            diag2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            col4[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 2 && j > 1)
                    {
                        rowC2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 5)
                        {
                            col5[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 1 && j > 0 && j < 5)
                    {
                        rowB1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 1)
                        {
                            col1[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 2)
                        {
                            diag1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col2[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 3)
                        {
                            diag2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            diag3[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col3[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 4)
                        {
                            diag4[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            col4[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 1 && j > 1)
                    {
                        rowB2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 5)
                        {
                            col5[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 0 && j > 0 && j < 5)
                    {
                        rowA1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 1)
                        {
                            diag1[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col1[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 2)
                        {
                            diag2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            col2[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 3)
                        {
                            col3[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                        else if (j == 4)
                        {
                            diag3[j - 1] = Convert.ToChar(board.GetValue(i, j));
                            col4[i] = Convert.ToChar(board.GetValue(i, j));
                        }
                    }
                    if (i == 0 && j > 1)
                    {
                        rowA2[j - 2] = Convert.ToChar(board.GetValue(i, j));
                        if (j == 5)
                        {
                            diag4[j - 2] = Convert.ToChar(board.GetValue(i, j));
                            if (j == 5)
                            {
                                col5[i] = Convert.ToChar(board.GetValue(i, j));
                            }
                        }
                    }
                }
            }
        }

        public int determine_winner()
        {
            List<char[]> conditionsList = new List<char[]>
            {
                rowD1, rowD2, rowC1, rowC2, rowB1, rowB2, rowA1, rowA2, col1, col2, col3, col4, col5, diag1, diag2, diag3, diag4
            };
            foreach (char[] condition in conditionsList)
            {
                //Console.WriteLine(condition);
                if (condition.All(x => x == 'X'))
                {
                    Console.WriteLine("player1 wins");
                    return 1;
                }
                if (condition.All(c => c == 'O'))
                {
                    Console.WriteLine("player2 wins");
                    return 2;
                }
                if (condition.All(d => d != 'X' && d != 'O' && d != '_'))
                {
                    Console.WriteLine("draw");
                    return 3;
                }

            }
            return 0;
        }
    }
}