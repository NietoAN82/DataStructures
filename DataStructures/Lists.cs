using System;
using System.Collections.Generic;


namespace DataStructures
{
    //Creating a new list
    
    public class Lists
    {
        //Creating a new list
        static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
        public static void Main(string[] args)
        {
            //Count property counts the number of items in the list.
            //System.Diagnostics.Debug.WriteLine(numbers.Count);

            //Capacity property let's us set or get the total number of elements that the list can hold
            numbers.Capacity = 20;

            //Add method lets us add an element to the end of the list.
            numbers.Add(6);

            //Add several elements to the end of the list using the AddRange method.
            List<int> subList = new List<int>() { 7, 8 };
            numbers.AddRange(subList);

            //Search for an element in the list using binary search. Binary search requires the list to be sorted first.
            numbers.Sort();
            System.Diagnostics.Debug.WriteLine("Index of element 5 is " + numbers.BinarySearch(5));

            //Contains method allows us to check if the element is contained in the list. Returns a bool
            System.Diagnostics.Debug.WriteLine(numbers.Contains(3));
            System.Diagnostics.Debug.WriteLine(numbers.Contains(20));

            //To clear the list, use the Clear method.
            //numbers.Clear();

            //Insert a number into a specified index using the insert function.
            //Insert function takes two arguments: the index you want to insert the item at, the actual element you want to add
            numbers.Insert(0, 9);

            //InsertRange is the same as Insert but can insert a range of values
            List<int> subList2 = new List<int>() { 0, 1, 2 };
            numbers.InsertRange(1, subList2);

            //Remove an element from the list using the Remove function. Only first element found will be deleted.
            numbers.Remove(3);

            //RemoveAt removes a specified element from the list
            numbers.RemoveAt(0);

            //RemoveRange removes a range of values in the list. Example below removes 3 elements starting from the first element.
            numbers.RemoveRange(0, 3);
        }
    }
}
