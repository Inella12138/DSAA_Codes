using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DictImplWithArrays
{
    public class Dictionary
    {
        Entry[] entries;
        public int numElements { get; set; }

        public Dictionary() 
        {
            entries = new Entry[10];
            numElements = 0;
        }

        public void Add(int key, string value)
        {
            if (Contains(key))
            {
                throw new ArgumentException("The value already exists!");
            }
            else
            {
                Entry newElement = new Entry(key, value);
                entries[numElements] = newElement;
                numElements++;
            }
        }

        public bool Contains(int key)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i].Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
