using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */

            //your code here
            int rows = matrixOfIntegers.GetLength(0);
            int cols = matrixOfIntegers.GetLength(1);
            if (rows % 2 == 1 && cols % 2 == 1)
            {
                int i = rows / 2;
                int j = cols / 2;
                Console.WriteLine(matrixOfIntegers[i, j]);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            int rows = matrixOfIntegers.GetLength(0);
            int cols = matrixOfIntegers.GetLength(1);
            int sum = 0;
            int sum1 = 0;
            if (rows == cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    sum += matrixOfIntegers[i, i];
                    //sum = sum + matrixOfIntegers[i,i];
                    sum1 += matrixOfIntegers[i, rows - i - 1];  // [0,3-0-1] - [1,3-1-1] - [2,3 -2-1]
                    //sum1 = sum1 + matrixOfIntegers[i, rows - i - 1];
                }
                Console.WriteLine("First diagonal: " + sum);
                Console.WriteLine("Second diagonal: " + sum1);

            }
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonals");
            }

        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here

            int i, j, temp;

            temp = triangleHight;
            for (i = 1; i <= triangleHight; i++)
            {
                for (j = 1; j < temp; j++)
                    Console.Write(" ");

                temp--;
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            
        }
        public void SortList(IList<int> listOfNumbers)
        {
            int temp;
            //listOfNumbers.Sort();
            for (int j = 0; j <= listOfNumbers.Count - 2; j++)
            {
                for (int i = 0; i <= listOfNumbers.Count - j - 2; i++)
                {
                    if (listOfNumbers[i] > listOfNumbers[i + 1])
                    {
                        temp = listOfNumbers[i + 1];
                        listOfNumbers[i + 1] = listOfNumbers[i];
                        listOfNumbers[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in listOfNumbers)
                Console.Write(p + " ");

            //Print to console elements of  listOfNumbers in ascending order
            //your code here
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(10);
            homework.SortList(list);
        }

    }
}