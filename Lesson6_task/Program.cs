using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = "";
            do
            {
                comand = Console.ReadLine();
                switch (comand)
                {
                    case "1":
                        Print(Matrix1(8));
                        break;
                    case "2":
                        Print(Matrix2(8));
                        break;
                    case "3":
                        Print(Matrix3(8));
                        break;
                    case "4":
                        Print(Matrix4(8));
                        break;
                    default:
                        Console.WriteLine("Неверная команда. Попробуйте еще раз.");
                        break;
                }
            } while (comand != "exit");
        }

        static int[,] Matrix1(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }

        static int[,] Matrix2(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j <= i)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        static int[,] Matrix3(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == i)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        static int[,] Matrix4(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
