using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortedSets
    {
        static SortedSet<int> sortedSet = new SortedSet<int>();

        public static void Main(string[] args)
        {
            //Add method adds an element to the set and we'll also return a value that shows whether or not hte element
            //was successfully added to the set
            sortedSet.Add(3);
            sortedSet.Add(1);

            //Output will be sorted even though 3 was added before 1.
            foreach(int i in sortedSet)
            {
                System.Diagnostics.Debug.WriteLine(i);
            }

            //Check if sorted set contains integer value using .Contains(value)
            if (sortedSet.Contains(1))
            {

            }

            //Check if element is part of specified collection using IsSubsetOf
            if (sortedSet.IsSubsetOf(new List<int>() { 1 , 2, 3 }))
            {

            }
            //IsSupersetOf will check if elements contained in specified collection exist inside of sorted set

            //.Overlaps will return true if one or more elements that are present in the sorted set are present in 
            //specified collection, otherwise return false

            //Remove method removes specified item from sorted set

            //RemoveWhere removes item where the condition is met 
            sortedSet.RemoveWhere(x => x > 2);

            //.Reverse() will return an IEnumarable T that iterates over the sorted set in reverse
            foreach(int i in sortedSet.Reverse())
            {

            }
            //UnionWith method will add any element either in sorted set or collection all into one sorted set
            List<int> list2 = new List<int> { 6, 7, 8 };
            sortedSet.UnionWith(list2);
            foreach(int i in sortedSet) { 
            
            }
        }
    }
}
