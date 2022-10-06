using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //1.Find out minimal value in array.
            //int[] nums = new int[] { 1,2,3,4,5,6, -1 , -5,10,25};

            //static int FindMinValue(int[] nums)
            //{
            //    int minValue = nums[0];
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] < minValue)
            //        {
            //            minValue = nums[i];
            //        }
            //    }
            //    return minValue;
            //}
            //int minValue = FindMinValue(nums);
            //Console.WriteLine(minValue);
            #endregion

            #region Task 2
            //2.Find out maximal value in array.
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 55, 60, 6, -1, -5, 10, 25 };

            //static int FindMaxValue(int[] nums)
            //{
            //    int maxValue = nums[0];
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] > maxValue)
            //        {
            //            maxValue = nums[i];
            //        }
            //    }
            //    return maxValue;
            //}
            //int maxValue = FindMaxValue(nums);
            //Console.WriteLine(maxValue);
            #endregion

            #region Task 3
            //3.Find out index of minimal value in array.

            //int[] nums = new int[] { 1, 6, -1, -5, 10, 25 };

            //static int FindMinValueIndex(int[] nums)
            //{
            //    int minValueIndex = 0;
            //    int minValue = nums[0];
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] < minValue)
            //        {
            //            minValue = nums[i];
            //            minValueIndex = i;
            //        }
            //    }
            //    return minValueIndex;
            //}
            //int minValueIndex = FindMinValueIndex(nums);
            //Console.WriteLine(minValueIndex);
            #endregion

            #region Task 4
            //4.Find out index of maximal value in array.

            //int[] nums = new int[] { 1, 6, 50, -1, -5, 10, 25 };

            //static int FindMaxValueIndex(int[] nums)
            //{
            //    int maxValueIndex = 0;
            //    int maxValue = nums[0];
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] > maxValue)
            //        {
            //            maxValue = nums[i];
            //            maxValueIndex = i;
            //        }
            //    }
            //    return maxValueIndex;
            //}
            //int maxValueIndex = FindMaxValueIndex(nums);
            //Console.WriteLine(maxValueIndex);
            #endregion

            #region Task 5 
            //5.Calculate sum of all elements with odd indexes.

            //int[] nums = new int[] { 1, 6, -5, 10, 25, 4 };

            //static int SumOddIndexedElements(int[] nums)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //       if(i % 2 == 1)
            //        {
            //            sum += nums[i];
            //        }
            //    }
            //    return sum;
            //}
            //int sum = SumOddIndexedElements(nums);
            //Console.WriteLine(sum);
            #endregion

            #region Task 6 
            //6.Reverse an array (f.e. 1 2 3 4 5-> 5 4 3 2 1)

            //int[] nums = new int[] { 1, 2, 3, 4, 5 };

            //static void ReverseArray(int[] nums)
            //{
            //    for (int i = 0; i < nums.Length / 2; i++)
            //    {
            //        int temp = nums[i];
            //        nums[i] = nums[nums.Length - i - 1];
            //        nums[nums.Length - i - 1] = temp;
            //    }
            //   for(int j=0; j < nums.Length; j++)
            //    {
            //        Console.WriteLine(nums[j]);
            //    }
            //}
            //ReverseArray(nums);

            #endregion

            #region Task 7 
            //7.Calculate amount of all elements with odd values.

            //int[] nums = new int[] { 1, 6, -5, 10, 25, 4, 20, 3 };

            //static int CalculateAmountOddValuedElements(int[] nums)
            //{
            //    int counter = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //       if(nums[i] % 2 == 1)
            //        {
            //            counter++;
            //        }
            //    }
            //    return counter;
            //}
            //int amount = CalculateAmountOddValuedElements(nums);
            //Console.WriteLine(amount);
            #endregion

            #region Task 8 
            //8.Change first and second half of array(f.e. 1 2 3 4 -> 3 4 1 2, or 1 2 3 4 5-> 4 5 3 1 2

            //int[] nums = new int[] { 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10};

            //static void ChangeHalvesArray(int[] nums)
            //{
            //    int halfNumsLength = nums.Length / 2;
            //    if(nums.Length % 2 == 1)
            //    {
            //        for (int i = 0; i < halfNumsLength; i++)
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[halfNumsLength + i + 1];
            //            nums[halfNumsLength + i + 1] = temp;
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < halfNumsLength; i++)
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[halfNumsLength + i];
            //            nums[halfNumsLength + i] = temp;
            //        }
            //    }

                
            //   for(int j=0; j < nums.Length; j++)
            //    {
            //        Console.WriteLine(nums[j]);
            //    }
            //}
            //ChangeHalvesArray(nums);
            #endregion

            #region Task 9 
            //9.Sort array with one of those methods: bubble, select or insert.

            //bubble sort

            //int[] nums = new int[] { 2, 3, 1, 5, 4, -1 , 7 };
            //static void SortArray(int[] nums)
            //{
            //    for(int i = 0; i < nums.Length - 1; i++)
            //    {
            //        for(int j = i+1; j < nums.Length; j++)
            //        {
            //            if(nums[j] < nums[i])
            //            {
            //                int temp = nums[i];
            //                nums[i] = nums[j];
            //                nums[j] = temp;
            //            }
            //        }
            //    }

            //    foreach(int num in nums)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //SortArray(nums);

            #endregion

            #region Task 10
            //10.Sort array with quick-sort, timsort, shell-sort, mergesort.


            #endregion

        }

    }
}
