/*

Given two arrays, write a function to compute their intersection - the intersection means the numbers that are in both arrays.

Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Note:
Each element in the result must be unique.
The result can be in any order.

*/

using System;
using System.Collections;

namespace ArrayIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 2, 1 };
            int[] arr2 = { 2, 2 };

            Intersection(arr1, arr2);

            int[] arr3 = { 4, 9, 5 };
            int[] arr4 = { 9, 4, 9, 8, 4 };

            Intersection(arr3, arr4);

            Console.ReadKey();
        }

        public static void Intersection(int[] arr1, int[] arr2)
        {
            ArrayList array = new ArrayList();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int z = 0; z < arr2.Length; z++)
                {
                    if(arr1[i] == arr2[z])
                    {
                        if (!array.Contains(arr1[i]))
                        {
                            array.Add(arr1[i]);
                            break;
                        }
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write($"{item}");
            }
        }
    }
}
