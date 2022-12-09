# Heap Sort for Ness
Course assignment - find and implement in C# a sorting algorithm with better time complexity than O(n^2)

## What is the Heap Sort algorithm?
A heap is an ordered binary tree. 
A max heap is a heap with a restriction that the value of the parent node is greater than the value of the child node.
For this algorithm implementation, we will use 2 main functions:
**BuildMaxHeap** - Creates a max heap from an unsorted array.
**Heapify** - Function to build max heap from an array, but assume that the array is divided into sorted and unsorted partitions.

## How to implement it?
1. Create a max heap from the unsorted array.
2. Extract the largest item from the heap.
3. Replace the extracted item with the last item in the unsorted partition of the array.
4. Repeat the above process and gradually increase the sorted partition of the array, until we have a single item in the heap, which means that the array is fully sorted.

## Why did i chose it?
I chose the Heap Sort algorithm over the other methods due to its O(n log n) time complexity (also in the worst case scenarios) and due to its efficient O(1) space complexity (which comes along with the in-place sorting techniques).

## What are the disadvantages of the algorithm?
Heap Sort is an unstable sorting algorithm. Meaning that in case of sorting a key-value collection, this kind of algorithm will not maintain the original order of the items. What can may cause replacing the original order 2 or more items, if their keys are the same.