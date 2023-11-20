using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    internal class Program
    {
        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);

            }
        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i + 1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Console.WriteLine("The given Array is not sorted");
                }
            }
            Console.WriteLine("The Array is sorted");
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] array = { 2, -3, 5, 9, 6, 7, -6, 1, 3 };
            Console.WriteLine("Orginal Array");
            Print(array);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(array);
            stopwatch.Stop();
            Console.WriteLine("After Quick Sort");
            Print(array);
            Console.WriteLine($"ArraySize {array.Length} Time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(array);
            Console.WriteLine();

            int[] array1 = { 12, 15, 5, 9, 6, 7, 11, 1, 3 };
            Console.WriteLine("Orginal Array");
            Print(array1);

      
            stopwatch.Start();
            QuickSort(array1);
            stopwatch.Stop();
            Console.WriteLine("After Quick Sort");
            Print(array1);
            Console.WriteLine($"ArraySize {array1.Length} Time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(array1);
            Console.WriteLine();

            int[] array2 = { 22, 15, 53, 10, 30, 27, 31, 11, 13 ,8,9};
            Console.WriteLine("Orginal Array");
            Print(array2);


            stopwatch.Start();
            QuickSort(array2);
            stopwatch.Stop();
            Console.WriteLine("After Quick Sort");
            Print(array2);
            Console.WriteLine($"ArraySize {array2.Length} Time taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            IsSorted(array2);
            Console.WriteLine();

            Console.ReadKey();



        }
    }
}
