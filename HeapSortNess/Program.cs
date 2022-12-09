using System;

namespace HeapSortNess
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 6, 2, 5, 1, -2, 43, 22, 2 };

            HeapSort(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

        }

        // Function to recieve array of integeres and sort it according to the Heap Sort algorithm
        public static void HeapSort(int[] arr)
        {
            int heapSize = arr.Length;

            BuildMaxHeap(arr);

            // One by one replace the largest element on the heap with the last element from the unsorted partition
            for (int i = heapSize - 1; i >= 1; i--)
            {
                Swap(arr, i, 0);
                heapSize--;
                Heapify(arr, heapSize, 0);
            }
        }

        // Function to receive an unsorted array of integers and creates a Max Heap from it
        public static void BuildMaxHeap(int[] arr)
        {
            int heapSize = arr.Length;

            for (int i = heapSize / 2 - 1; i >= 0; i--)
                Heapify(arr, heapSize, i);
        }

        // Function to return the array back to its Max Heap form, will traverse each time from the startIndex downwards 
        public static void Heapify(int[] arr, int heapSize, int startIndex)
        {
            int largest = startIndex;
            int leftChild = 2 * startIndex + 1; // Find the left child
            int rightChild = 2 * startIndex + 2; // Find the right child

            // If the left child is larger than the root, replace its index with the largest element
            if (leftChild < heapSize && arr[leftChild] > arr[largest])
                largest = leftChild;

            // If the right child is larger than the root, replace its index with the largest element
            if (rightChild < heapSize && arr[rightChild] > arr[largest])
                largest = rightChild;

            // If largest is not the root
            if (largest != startIndex)
            {
                // Swap between the largest element in the array and the last element in the unsorted partition
                Swap(arr, startIndex, largest);

                // Recursively reorder the heap until its returns to max heap form
                Heapify(arr, heapSize, largest);
            }
        }

        // Function to swap between 2 integers in a given integers array
        public static void Swap(int[] arr, int firstPosition, int secondPosition)
        {
            int temp = arr[firstPosition];
            arr[firstPosition] = arr[secondPosition];
            arr[secondPosition] = temp;
        }
    }


}
