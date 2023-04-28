using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// Example of a struct.
    /// </summary>
    struct Example: INotifyPropertyChanged
    {
        string Ex;
        int Ex2;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
