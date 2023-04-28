using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    
    public class Example
    {
        enum Weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        public static void Main(string[] args)
        {
            //GetName will return enum member that has the value specified
            Debug.WriteLine(Enum.GetName(typeof(Weekday), 6));

            //use GetNames to display list of names in the specified enum
            foreach(string s in Enum.GetNames(typeof(Weekday)))
            {
                Debug.WriteLine(s);
            }

            //useGetValues to display list of values of the elements.
            foreach (int i in Enum.GetValues(typeof(Weekday)))
            {
                Debug.WriteLine(i);
            }
        }
        
    }
}
