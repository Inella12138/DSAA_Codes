using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementListsWithArrays
{
    internal class AList
    {
        private const int DEFAULT_CAPACITY = 2;
        private string[] arr;
        private int numElements;

        //Constructor
        //AList实质上是一个人为定义的object
        public AList()
        {
            arr = new string[DEFAULT_CAPACITY];//默认数组长度10
            numElements = 0;
        }

        //Count()方法，返回元素个数
        public int Count()
        {
            return numElements;
        }

        //Add(string newElement)
        public void Add(string newElement)
        {
            arr[numElements++] = newElement;

            EnsureCapacity();
        }

        //Insert(int index, string newElement)，在第(index+1)个元素前插入newElement
        //这里的索引index范围从0 ~ (numElements-1）
        public void Insert(int index, string newElement)
        {
            if (index >= 0 && index <= numElements)
            { 
                if (index < numElements)
                {
                    for (int i = numElements; i > index; i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                }
                arr[index] = newElement;
                numElements++;

                EnsureCapacity();
            }
        }

        //RemoveAt(int index)，删除第(index+1)个元素
        public void RemoveAt(int index) 
        {
            if (index >= 0 && index <= numElements - 1)
            {
                if (index < numElements - 1)
                {
                    for (int i = index; i < numElements - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                }
                numElements--;
                //这里用了一种简单的方法来删除元素
                //当要删除的元素是最后一个元素时(index == numElements-1)
                //观察代码会发现函数只执行了numElements--的操作
                //即这里的删除元素是通过删除索引来完成的，并没有直接删除元素内容
                //实际上删除元素内容也只会增加代码复杂度
            }
        }

        //Replace(int index, string newElement)
        public void Replace(int index, string newElement)
        {
            if (index >= 0 && index <= numElements - 1)
            {
                arr[index] = newElement;
            }
        }

        //Contains(string element)
        public bool Contains(string element)
        {
            bool flag = false;
            for (int i = 0; i < numElements - 1; i++)
            {
                if (element.Equals(arr[i]))  { flag = true; }
            }
            return flag;
        }

        //GetAt(int index)
        public string GetAt(int index)
        {
            if (index >= 0 && index <= numElements - 1)
            {
                return arr[index];
            }
            else
            {
                return null;
            }
            //if else防止索引溢出
        }

        //Write()打印列表中所有元素
        public void Write()
        {
            Console.WriteLine();
            for (int i = 0; i < numElements; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //EnsureCapacity()，每当元素量达到上限时，将容量翻倍
        private void EnsureCapacity()
        {
            int capacity = arr.Length;
            if (numElements >= capacity)
            {
                int newCapacity = 2 * capacity;
                string[] newArr = new string[newCapacity];
                arr.CopyTo(newArr, 0);
                arr = newArr;
            }
        }
    }
}
