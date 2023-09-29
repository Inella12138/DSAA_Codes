using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictImplWithArrays
{
    class Entry
    {
        public int Key { get; set; }

        public string Value { get; set; }

        public Entry(int key,string value)
        {
            Key = key;
            Value = value;
        }
    }
}
