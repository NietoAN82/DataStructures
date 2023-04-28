using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class mainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //Adding an item to the dictionary
            dictionary.Add("key1", "values1");
            dictionary.Add("key2", "values2");
            dictionary.Add("key3", "values3");

            //Count values of key pairs present in the dictionary
            Debug.WriteLine(dictionary.Count);

            //Keys property allows us to get a collection of all they keys in the dictionary
            //collections returned by this property are ordered and can be iterated.
            foreach(string key in dictionary.Keys)
            {
                Debug.WriteLine(key);
            }

            //Values property to go through each of the values
            foreach (string value in dictionary.Values)
            {
                Debug.WriteLine(value);
            }

            //Remove method removes values from dictionary. Make sure to check that dictionary
            //does not contain a key before adding item with same key
            dictionary.Remove("key1");

            //Find value of key by using dictionary["key"]
            Debug.WriteLine(dictionary["key"]);

            //Note: When adding or removing, make sure the key exists
            if (dictionary.ContainsKey("key5"))
            {
                Debug.WriteLine(dictionary["key5"]);
            }
            // Use the TryGetValue method when you want to get a value from the dictionary, as it combines containskey check
            // and getting value in same method. If no value is found, default value set will be outputted.
            string value = "";
            dictionary.TryGetValue("key1", out value);

            //To remove all values in key value pair, use Clear()
            dictionary.Clear();
        }
    }
}
