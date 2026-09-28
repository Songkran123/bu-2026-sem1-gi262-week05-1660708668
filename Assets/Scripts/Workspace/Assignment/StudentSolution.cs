using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        
        {
            int n = numbers.Length;
            for (int i = 0; i < n-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                    
                }
                //int temp = numbers[minIndex];
                //numbers[minIndex] = numbers[i];
                //numbers[i] = temp;
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j>= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            if (numbers == null)
            {
                return new int[0];
            }
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] > result[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                if (maxIndex != i)
                {
                    int temp = result[i];
                    result[i] = result[maxIndex];
                    result[maxIndex] = temp;
                }
            }
            return result;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            if (numbers == null)
            {
                return new int[0];
            }
            int[] result = (int[])numbers.Clone();
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            if (numbers == null)
            {
                return new int[0];
            }
            int[] result = (int[])numbers.Clone();
            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;
                while (j >= 0 && result[j] < key)
                {
                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = key;
            }
            return result;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    secondLargest = largest;
                    largest = numbers[i];
                }
                else if (numbers[i] > secondLargest && numbers[i] != largest)
                {
                    secondLargest = numbers[i];
                }
            }

            return secondLargest;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            int[] result = (int[])numbers.Clone();
            
            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }
                
                if (minIndex != i)
                {
                    int temp = result[i];
                    result[i] = result[minIndex];
                    result[minIndex] = temp;
                }
            }
            
            int currentLength = 1;
            
            int longestLength = 1;
            
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1] + 1)
                {
                    currentLength++;
                }
                else if (result[i] == result[i - 1])
                {
                    continue;
                }
                else
                {
                    currentLength = 1;
                }
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                }
            }

            return longestLength;
        }

        #endregion
    }
}
