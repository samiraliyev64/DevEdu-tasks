using System;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //1.Find out minimal element.
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { -1, 10 } };
            //int minValue = array2D[0,0];
            //for(int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if(array2D[i,j] < minValue)
            //        {
            //            minValue = array2D[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine(minValue);
            #endregion

            #region Task 2
            //2.Find out maximal element.
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { -1, 10 } };
            //int maxValue = array2D[0, 0];
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if (array2D[i, j] > maxValue)
            //        {
            //            maxValue = array2D[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine(maxValue);

            #endregion

            #region Task 3
            //3.Find out index of maximal element.
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { -1, 10 } };
            //int maxValue = array2D[0, 0];
            //int firstIndex = 0;
            //int secondIndex = 0;
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if (array2D[i, j] > maxValue)
            //        {
            //            maxValue = array2D[i, j];
            //            firstIndex = i;
            //            secondIndex = j;
            //        }
            //    }
            //}
            //Console.WriteLine($"[{firstIndex}, {secondIndex}]");
            #endregion

            #region Task 4
            //4.Find out index of minimal element.
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { -1, 10 } };
            //int minValue = array2D[0, 0];
            //int firstIndex = 0;
            //int secondIndex = 0;
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if (array2D[i, j] < minValue)
            //        {
            //            minValue = array2D[i, j];
            //            firstIndex = i;
            //            secondIndex = j;
            //        }
            //    }
            //}
            //Console.WriteLine($"[{firstIndex}, {secondIndex}]");
            #endregion

            #region Task 6
            //6.Mirror array from it’s main diagonal.

            //int n = 5;
            //int[,] arr = new int[n, n];
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr[i, j] = rand.Next(9, 100);
            //    }
            //}


            //PrintArray(arr);
            //MirrorArray(arr);
            //Console.WriteLine("\nArray mirrored!\n");
            //PrintArray(arr);


            //void MirrorArray(int[,] arr)
            //{
            //    for (int i = 0; i < arr.GetLength(0) / 2 - 1; i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            (arr[j, i], arr[i, j]) = (arr[i, j], arr[j, i]);
            //        }

            //    }
            //}

            //void PrintArray(int[,] arr)
            //{
            //    Console.WriteLine("Array: \n");

            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //            Console.Write(arr[i, j] + " ");
            //        Console.WriteLine();
            //    }
            //}
            #endregion
        }
    }
}
