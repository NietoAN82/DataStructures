using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   
    class SortedDictionaries
    {
        static SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>()
        {
            { "key1", "value1" },
            { "key2", "value2" },
            { "key3", "value3" }
        };

        public static void Main(string[] args)
        {
            //Add to dictionary the same way as before
            sortedDictionary.Add("key4", "value4");

            //Count property that can be used to receive the number of elements it contains

            //Keys and values properties to get a list of the keys and values respectively.

            //Comparer property that is used to compare the icomparer that is used to order its elements.
            System.Diagnostics.Debug.WriteLine(sortedDictionary.Comparer.ToString());

            //ContainsKey("key") can be used to check if key is in list.
            //ContainsValue("value") can be used to check if value is in the list.

            //TryGetValue("key", out value) can be used to check for a key and get value
            string value = string.Empty;
            sortedDictionary.TryGetValue("key1", out value);

            //Remove element using Remove function passing key 
            sortedDictionary.Remove("key2");
            //Remove all values
            sortedDictionary.Clear();
        }
    }
}
