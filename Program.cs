using System;
using System.Collections.Generic;

namespace basic_13
{
    class Program
    {
        // Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            for(int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
        }

        // Print all of the odd integers from 1 to 255.
        public static void PrintOdds()
        {
            for(int i = 1; i < 256; i++) {
                if(i %2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }

        // Print all of the numbers from 0 to 255, but this time, also print the sum as you go. 
        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i < 256; i++) {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        // Write a function that would iterate through each item of the given integer array and print each value to the console. 
        public static void LoopArray(params int[] numbers)
        {
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        // Write a function that takes an integer array and prints and returns the maximum value in the array. 
        // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), or even a mix of positive numbers, negative numbers and zero.
        public static int FindMax(params int[] numbers)
        {
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++) {
                if(numbers[i] > max) {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }

        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        public static void GetAverage(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("Average: " + sum /numbers.Length);
        }

        // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        public static int[] OddArray()
        {
            var arr = new List<int>();
            for(int i = 1; i <= 255; i++) {
                if(i %2 == 1) {
                    arr.Add(i);
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item + ", ");
            }
            return arr[];
        }

        // Write a function that takes an integer array, and a integer "y" and returns the number of array values that are greater than the "y" value. 
        public static int GreaterThanY(int y, params int[] numbers)
        {
            int count = 0;
            foreach (var num in numbers)
            {
                if(num > y) {
                    count += 1;
                }
            }
            Console.WriteLine($"Number of integers greater than {y}: {count}");
            return count;
        }

        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        public static void SquareArrayValues(params int[] numbers)
        {
            if (numbers is null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }
            foreach (var num in numbers)
            {
                Console.Write(num*num);
            }
        }

        // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        public static void EliminateNegatives(params int[] numbers)
        {
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for(int i = 0; i < numbers.Length; i++) {
                if(numbers[i] < 0) {
                    numbers[i] = 0;
                }
            }
            foreach (var num in numbers)
            {
                Console.Write($"{num}, ");
            }
        }

         // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(params int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];
            foreach (var num in numbers)
            {
                if(num < min) {
                    min = num;
                }
                else if(num > max) {
                    max = num;
                }
                sum += num;
            }
            Console.WriteLine($"The minimum is: {min}. The maximum is: {max}. The average is {sum/numbers.Length}.");
        }

        // Given an integer array, say [1, 5, 10, 7, -2], write a function that shifts each number by one to the front and adds '0' to the end. 
        public static void ShiftValues(List<int> numbers)
        {
            numbers.RemoveAt(0);
            numbers.Add(0);
            Console.Write("[");
            foreach (var num in numbers)
            {
                Console.Write(num + ", ");
            }
            Console.Write("]");
        }

        // Write a function that takes an integer array and returns an object array that replaces any negative number with the string 'Dojo'.
        public static object[] NumToString(params int[] numbers)
        {
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            string numbersAsString = numbers.ToString();
            for(int i = 0; i < numbersAsString.Length; i++) {
                if(numbersAsString[i] < 0) {
                    numbersAsString[i] = "Dojo";
                }
            }
            return numbersAsString;
        }


        static void Main(string[] args)
        {
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(1,2,3,4);
            FindMax(-3, 5, -7, 10);
            GetAverage(2, 10, 3);
            OddArray();
            GreaterThanY(3, 1,3,4,7);
            SquareArrayValues(1,5,10,10);
            EliminateNegatives(1,5,10,-2);
            MinMaxAverage(1,5,10,-2);
            ShiftValues(new List<int> {1,5,10,7,-2});
            NumToString(-1,-2,3);
        }
    }
}
