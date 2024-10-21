using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                    // Using the input array to mark visited numbers by negating their corresponding indices
                List<int> result = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                    {
                        nums[index] = -nums[index];
                    }
                }

                // Adding the index of positive numbers as missing numbers
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1);
                    }
                }
                return result;  // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                // Creating an array with even numbers at the start and odd numbers at the end
                int[] result = new int[nums.Length];
                int evenIndex = 0;
                int oddIndex = nums.Length - 1;

                foreach (int num in nums)
                {
                    if (num % 2 == 0)
                    {
                        result[evenIndex++] = num;
                    }
                    else
                    {
                        result[oddIndex--] = num;
                    }
                }
                return result; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                // Using a dictionary to store the complement and its index
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }
                    map[nums[i]] = i;
                }
                return new int[0]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                // Sorting the array to find the maximum product of either the largest three numbers
                // or two smallest negative numbers with the largest positive number
                Array.Sort(nums);
                int n = nums.Length;
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[0] * nums[1] * nums[n - 1]);// Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                // Converting decimal number to binary using modulus and division by 2
                string result = "";
                while (decimalNumber > 0)
                {
                    result = (decimalNumber % 2) + result;
                    decimalNumber /= 2;
                }
                return result == "" ? "0" : result;// Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                // Binary search to find the minimum in the rotated sorted array
                int left = 0, right = nums.Length - 1;
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                return nums[left]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                // Checking if the number is negative or if it ends with 0 but is not zero
                if (x < 0 || (x % 10 == 0 && x != 0))
                {
                    return false;
                }

                int reversed = 0;
                int original = x;

                // Reversing the number to check for palindrome
                while (x > 0)
                {
                    int pop = x % 10;
                    reversed = reversed * 10 + pop;
                    x /= 10;
                }

                return original == reversed; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                // Iterative approach to calculate Fibonacci numbers
                if (n <= 1) return n;
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
