using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Demo !");
            BST<int> BinarySearch = new BST<int>(56);
            BinarySearch.Insert(30);
            BinarySearch.Insert(70);
            BinarySearch.Display();
        }
    }
}
