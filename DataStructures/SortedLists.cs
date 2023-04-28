using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortedLists
    {
        //Initialize the SortedList
        static SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };
        public static void Main(string[] args)
        {
            //Can set a capacity using the .Capacity property
            sortedList.Capacity = 10;

            //Also uses .count to count key value pairs in sortedList
            Debug.WriteLine(sortedList.Count);

            //Uses the .Keys and .Values properties as seen before.
            foreach(string s in sortedList.Keys)
            {
                Debug.WriteLine(s);
            }
            foreach (int value in sortedList.Values)
            {
                Debug.WriteLine(value);
            }

            //Add key value pair to sorted list
            sortedList.Add("key4", 4);

            //Remove() function passes in a key to remove the element with that key
            sortedList.Remove("key1")
            //Remove element at index provided with RemoveAt() function
            sortedList.RemoveAt(0);

            //Use Contains() or ContainsValue method to check if key or value exists in sortedList
            if (sortedList.ContainsKey("key1"))
            {

            }
            if (sortedList.ContainsValue(2))
            {

            }

            //To remove all values from sortedList, use the Clear method
            sortedList.Clear();

            //use IndexOfKey method to find the index of key specified
            System.Diagnostics.Debug.WriteLine("Index of Key1:" + sortedList.IndexOfKey("key1"));
            System.Diagnostics.Debug.WriteLine("Index of Key2:" + sortedList.IndexOfKey("key2"));
            System.Diagnostics.Debug.WriteLine("Index of Key3:" + sortedList.IndexOfKey("key3"));

            //use IndexOfValue method to find index of value specified
            System.Diagnostics.Debug.WriteLine("Index of Value1:" + sortedList.IndexOfValue(1));
            System.Diagnostics.Debug.WriteLine("Index of Value2:" + sortedList.IndexOfValue(2));
            System.Diagnostics.Debug.WriteLine("Index of Value3:" + sortedList.IndexOfValue(3));
        }
    }
}
