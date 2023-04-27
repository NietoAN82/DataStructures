using System;
using System.Diagnostics;

namespace DataStructures
{
    class Arrays
    {
        // First way to create an array
        string[] strings = new string[3];

        //Second way to create an array
        string[] strings2 = new string[3] { "a", "b", "c"};

        //Third way to create an array;
        //Compiler understand what size of array it is based on specified values.
        string[] strings3 = new string[] { "a", "b", "c" };

        //Fourth way to create an array
        //Allows us to omit the new keyword
        string[] strings4 = { "a", "b", "c" };

        //Another example of creating an array
        static int[] array = new int[3] { 1, 2, 3 };

        public static void Main(string[] args)
        {
            //Debug.WriteLine(array[0]);

            //Set a value to the array
            //array[0] = 5;

            //Obtain length of the array
            //Debug.WriteLine(array.Length);

            //Sorting an array of integers
            //Array.Sort(array);
            //foreach(int i in array)
            //{
            //    Debug.WriteLine(i);
            //}

            //Sort an array of strings
            string[] stringarr = new string[] { "c", "a", "b" };
            Array.Sort(stringarr);
            foreach(string s in stringarr)
            {
                Debug.WriteLine(s);
            }
        }
    }
}