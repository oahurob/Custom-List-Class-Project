using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class List<T> : IEnumerable
    {
        public T[] list = new T[4];
        public int index;
        public int capacity;
        public T input;
        public int Count { get { return count; } }
        private int count;

        public T this[int index]
        {
            get
            {
                if (index > count - 1 || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return list[index];
            }
            set
            {
                if (index > count - 1 || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                list[index] = value;
            }
        }

        public List()
        {
            index = 0;
            count = 0;
            capacity = 4;
        }

        public void Add(T input)
        {
            if(count == capacity)
            {
                CopyList();
            }
            list[index] = input;
            index++;
        }

        public bool Remove(T itnput)
        {
            bool Removed = false;

            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(input))
                {
                    Removed = true;
                }
            }
            if (Removed)
            {
                count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder listToString = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                listToString.Append(list[i].ToString());
            }
            return listToString.ToString();

        }

        public T[] CopyList()
        {
            capacity *= 2;

            T[] temporary = new T[capacity];

            for (int i = 0; i < count - 1; i++)
            {
                temporary[i] = list[i];
            }

            return temporary;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }


    }
}
