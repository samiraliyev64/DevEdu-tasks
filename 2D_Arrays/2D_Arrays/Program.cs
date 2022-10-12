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


//            //Console.Write(min + ", ");
//            min_points[i] = $"{i}_{min_index}";
//        }

//    //max indexs
//    for (int j = 0; j<arr.GetLength(1); j++)
//    {
//        int max = arr[0, j];
//        int max_index = 0;
//        for (int i = 0; i<arr.GetLength(0); i++)
//        {
//            if (max<arr[i, j])
//            {
//                max = arr[i, j];
//                max_index = i;
//            }
//}

////    Console.Write(max + ", ");
//max_points[j] = $"{max_index}_{j}";

//    }

 


//    // Write min of rows
//    Console.WriteLine();
//Console.Write("min of rows: ");
//for (int i = 0; i < min_points.Length; i++)
//{
//    Console.Write(min_points[i] + ", ");
//}


//write max of columns
//Console.WriteLine();
//Console.Write("max of columns: ");
//for (int i = 0; i < max_points.Length; i++)
//{
//    Console.Write(max_points[i] + ", ");
//}
//Console.WriteLine();



//List<string> sandle_points = new List<string>();

//for (int i = 0; i < min_points.Length; i++)
//{
//    for (int j = 0; j < max_points.Length; j++)
//    {
//        if (min_points[i] == max_points[j])
//        {
//            sandle_points.Add(min_points[i]);
//            //  Console.Write(max_points[j] + " -- " + min_points[i]);
//        }
//    }

//}
/*
    if (sandle_points.Count != 0)
    {
        Console.Write("\n\nSandle Points: ");
        for (int i = 0; i < sandle_points.Count; i++)
            Console.Write(sandle_points[i] + ", ");

        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Sandle Point is not");
    }
*/


//return sandle_points;
//}


//void TaskSeven(float[,] float_arr, int index_k)
//{
//    Console.WriteLine($"Is {index_k} row Symmetrical: " + IsRowSymmetrycal(float_arr, index_k));
//    Console.WriteLine($"Is {index_k} row Descending: " + IsRowDescending(float_arr, index_k));
//    Console.WriteLine($"Is all zero of Is {index_k} column: " + IsAllZeroOfColumn(float_arr, index_k));
//}

////Is row symmetrycal or not
//bool IsRowSymmetrycal(float[,] arr, int rowIndex)
//{
//    bool is_symmetryc = true;
//    int i = rowIndex;

//    for (int j = 0; j < arr.GetLength(1) / 2; j++)
//    {
//        if (arr[i, j] != arr[i, arr.GetLength(1) - j - 1])
//        {
//            is_symmetryc = false;
//        }
//    }

//    return is_symmetryc;
//}

////Is row descending or not
//bool IsRowDescending(float[,] arr, int rowIndex)
//{
//    bool is_descending = true;
//    int i = rowIndex;

//    for (int j = 0; j < arr.GetLength(0) - 1; j++)
//    {
//        if (arr[i, j] < arr[i, j + 1])
//        {
//            is_descending = false;
//        }
//    }
//    return is_descending;
//}

////All elements of k-th column are 0;
//bool IsAllZeroOfColumn(float[,] arr, int columnIndex)
//{
//    bool all_is_zero = true;
//    int i = columnIndex;

//    for (int j = 0; j < arr.GetLength(0); j++)
//    {
//        if (arr[j, i] != 0)
//        {
//            all_is_zero = false;
//        }
//    }

//    return all_is_zero;
//}


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


//void WriteFloatArray(float[,] arr)
//{
//    Console.WriteLine("Array: \n");
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//            Console.Write(arr[i, j] + " ");
//        Console.WriteLine();
//    }
//}


//void WriteArray(int[,] arr)
//{
//    Console.WriteLine("--------");

//    Console.WriteLine("Array: \n");
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//            Console.Write(arr[i, j] + " ");
//        Console.WriteLine();
//    }
//    Console.WriteLine("--------");
//}
//        }
//    }
//}
