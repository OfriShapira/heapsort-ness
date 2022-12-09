# heap-sort-for-ness
Course assignment - find and implement in C# a sorting algorithm with better time complexity than O(n^2)

## What is the heap sort algorithm?
A heap is an ordered binary tree. 
A max heap is a heap with a restriction that the value of the parent node is greater than the value of the child node.
For this algorithm implementation, we will use 2 main functions:
BuildMaxHeap - Creates a max heap from an unsorted array.
Heapify - Function to build max heap from an array, but assume that the array is divided into sorted and unsorted partitions.

## What is the algorithm behind it?
Create a max heap from the unsorted array.
Extract the largest item from the heap.
Replace the extracted item with the last item in the unsorted partition of the array.
Repeat the above process and gradually increase the sorted partition of the array, until we have a single item in the heap, which means that the array is fully sorted.

## Why did i chose it?
I chose the Heap Sort algorithm over the other methods, due to its O(n log n) time complexity (in the worst case scenarios) and due to its efficient O(1) space complexity (which comes along with the in-place sorting techniques).

