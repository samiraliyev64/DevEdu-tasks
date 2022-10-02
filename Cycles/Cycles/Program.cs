using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //1.User gives 2 numbers a, b. Output a to the power of b (not using Math.pow).
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int temp = a;
            //Console.Write("Enter number b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //while(b > 1)
            //{
            //    a = a * temp;
            //    b--;
            //}
            //Console.WriteLine(a);
            #endregion

            #region Task 2
            //2.User gives 1 number a. Output amount of number from 1 to 1000 that have no reminder when divided by a.
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int counter = 0;
            //for(int i=1; i < 1000; i++)
            //{
            //    if(i % a == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            #endregion

            #region Task 3
            //3.User gives 1 number a. Output all positive numbers whose square will be lesser than a
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            ////a=20
            //for(int i=1; i * i <= a; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Task 4
            //4.User gives 1 number a. Output largest divisor to that number
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int box = 0;
            ////a=25
            //for(int i=1; i < a; i++)
            //{
            //    if(a % i == 0)
            //    {
            //        box = i;
            //    }
            //}
            //Console.WriteLine(box);
            #endregion

            #region Task 5
            //5.User gives 2 numbers a,b. Output sum of all numbers from range a to b that have no reminder when divided by 7.
            //(there can be situation when b lesser than a)
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //if (a < b)
            //{
            //    for (int i = a; i < b; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //}
            ////a= 10 b=5
            //else if (a > b)
            //{
            //    for (int i = b; i < a; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Task 6
            //6.User gives 1 number a. Output a-th number of Fibonacci’s series. (In Fibonacci series every next number is sum of previous two. F.e. : 1 1 2 3 5 8 13 21 …)
            //Console.Write("Enter number a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int num1 = 1;
            //int num2 = 1;

            //int[] fibonacciNums = new int[a];
            //fibonacciNums[0] = num1;
            //fibonacciNums[1] = num2;
            //for (int i=2; i < fibonacciNums.Length; i++)
            //{
            //    fibonacciNums[i] = num1+num2;
            //    num1 = fibonacciNums[i - 1];
            //    num2 = fibonacciNums[i];

            //}
            //Console.WriteLine(fibonacciNums[a-1]);
            #endregion

            #region Task 7
            //7.User gives 2 numbers. Find out their greatest common divisor using Euclid’s algorithm.
            //Console.Write("Enter num1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int box = 0;
            ////num1=10 num2=5  //output: 5
            //if(num1 > num2)
            //{
            //    for(int i=2; i <= num2; i++)
            //    {
            //        if(num1 % i == 0 &&  num2 % i == 0)
            //        {
            //            box = i;
            //        }
            //    }
            //    Console.WriteLine(box);
            //}
            //else if (num2 > num1)
            //{
            //    for (int i = 2; i <= num1; i++)
            //    {
            //        if (num1 % i == 0 && num2 % i == 0)
            //        {
            //            box = i;
            //        }
            //    }
            //    Console.WriteLine(box);
            //}
            #endregion

            #region  Task 8
            //8.User gives a positive number that is power of another number to 3. Find out that number using half division method. (F.e. : 8->2 )
            //Console.Write("Enter positive number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i=1; i < num; i++)
            //{
            //    if(i*i*i == num)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}
            #endregion

            #region Task 9
            //9.User gives 1 number. Find out amount of odd digits in this number.
            //Console.Write("Enter num: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = num;
            //int counter = 0;
            //while(temp > 0)
            //{
            //    int currentDigit = temp % 10;
            //    if(currentDigit % 2 != 0)
            //    {
            //        counter++;
            //    }
            //    temp = (temp - temp % 10) / 10;
            //}
            //Console.Write(counter);
            #endregion

            #region Task 10
            //10.User gives 1 number. Find out mirrored number to that one. F.e. : 1234 -> 4321.
            //Console.Write("Enter num: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = num;
            //int mirroredNum = 0;
            //while(temp > 0)
            //{
            //    int currentDigit = temp % 10;
            //    temp = (temp - currentDigit) / 10;
            //    mirroredNum = (mirroredNum * 10) + currentDigit;
            //}
            //Console.Write(mirroredNum);
            #endregion

            #region Task 11
            //11.User gives 1 number a. Find out every number in range 1 to a whose sum of even digits bigger than odd.
            //Console.Write("Enter num: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sumEven = 0;
            //int sumOdd = 0;
            //for(int i = 1; i < num; i++)
            //{
            //    int temp = i;
            //    while (temp > 0)
            //    {
            //        int currentDigit = temp % 10;
            //        if(currentDigit % 2 == 0)
            //        {
            //            sumEven += currentDigit;
            //        }
            //        else
            //        {
            //            sumOdd += currentDigit;
            //        }
            //        temp = (temp - currentDigit) / 10;
            //    }
            //    if(sumEven > sumOdd)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sumEven = 0;
            //    sumOdd = 0;
            //}
            #endregion

            #region Task 12
            //12.User gives 2 numbers. Find out if there are similar digits in those numbers.
            //Console.Write("Enter num1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int temp1 = num1;
            //int temp2 = num2;
            //while(temp1 > 0)
            //{
            //    int currentDigit1 = temp1 % 10;
            //    temp1 = (temp1 - currentDigit1) / 10;
            //    while(temp2 > 0)
            //    {
            //        int currentDigit2 = temp2 % 10;
            //        if(currentDigit1 == currentDigit2)
            //        {
            //            Console.WriteLine(currentDigit1);
            //        }
            //        temp2 = (temp2 - currentDigit2) / 10;
            //    }
            //    temp2 = num2;
            //}
            #endregion

            #region Task 13
            //User gives a number n. Calculate: (1 + 1 / 1 ^ 2) + (1 + 1 / 2 ^ 2) +…+(1 + 1 / n ^ 2)

            //Console.Write("Enter number n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double result = 0;
            //for(int i = 1; i <= n; i++)
            //{
            //    result = result +  (1 + (1 / Math.Pow(i, 2)));
            //}
            //Console.Write(result);
            #endregion

            #region Task 18
            //18.Find out every 3 - digit number that can be represented as sum of all its digit’s factorials.
            //static int factorial(int n)
            //{
            //    if (n == 0)
            //        return 1;

            //    return n * factorial(n - 1);
            //}
            //int sum = 0;
            //for (int i = 100; i <= 999; i++)
            //{
            //    int temp = i;
            //    while(temp > 0)
            //    {
            //        int currentDigit = temp % 10;
            //        int factorialDigit = factorial(currentDigit);
            //        sum += factorialDigit;
            //        temp = (temp - currentDigit) / 10;
            //    }
            //    if(i == sum)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sum = 0;
            //}
            #endregion

            #region Task 19
            //19.Is it possible to represent given number as sum of two positive numbers powered to 2?

            //Console.Write("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isPossible = false;
            //for(int i = 1; i < number; i++)
            //{
            //    for(int j = i+1; j<number; j++)
            //    {
            //        if(number == Math.Pow(i + j, 2))
            //        {
            //            Console.WriteLine($"Possible {i} + {j}");
            //            isPossible = true;
            //        }
            //    }
            //}
            //if (isPossible == false)
            //{
            //    Console.WriteLine("not possible");
            //}
            #endregion

            #region Task 20
            //20.Find out is given number perfect? I.e. number is equal to sum of all it’s positive divisors excepting the number by it’s own.

            //Console.Write("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for(int i=1; i < number; i++)
            //{
            //    if(number % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //if(sum == number)
            //{
            //    Console.WriteLine("perfect num");
            //}
            //else
            //{
            //    Console.WriteLine("not perfect num");
            //}
            #endregion

            #region Task 23
            //23.User gives one positive number k. Find out k-th number of Fibonacci’s series: 112358132134…
            //Console.Write("Enter number k: ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int num1 = 1;
            //int num2 = 1;

            //int[] fibonacciNums = new int[k];
            //fibonacciNums[0] = num1;
            //fibonacciNums[1] = num2;
            //for (int i=2; i < fibonacciNums.Length; i++)
            //{
            //    fibonacciNums[i] = num1+num2;
            //    num1 = fibonacciNums[i - 1];
            //    num2 = fibonacciNums[i];

            //}
            //Console.WriteLine(fibonacciNums[k-1]);
            #endregion

        }
    }
}
