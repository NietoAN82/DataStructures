using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class HashSets
    {
        public static void Main(string[] args)
        {
            HashSet<string> letters1 = new HashSet<string>() { "a", "b", "c" };
            HashSet<string> letters2 = new HashSet<string>() { "d", "e", "f", "a", "b" };

            //UnionWith method will merge 2 Hashsets entered
            //letters1.UnionWith(letters2);
            //foreach(string s in letters1)
            //{
            //    //Debug.WriteLine(s);
            //}

            //Intersectwith method allows us perform an intersection operation,
            //where the output intersect will meet the set containing only the elements present in both sets.
            letters1.IntersectWith(letters2);
            foreach (string s in letters1)
            {
                Debug.WriteLine(s);
            }

            //Excludewith method will give us any elements in set one that are not in set two. Result c
            letters1.ExceptWith(letters2);
            foreach (string s in letters1)
            {
                Debug.WriteLine(s);
            }
            // SymmetricExceptWith method allows us to take the symmetric difference between sets
        }
    }
}
