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

        public void EstablishList()
        {
          
        }

        public void Add(T input)
        {
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

        public T[] CopyList()
        {
            capacity *= 2;

            T[] temporary = new T[capacity];

            for (int i = 0; i < count - 1; i++)
            {
                //temporary[i] = list[i];
            }

            return temporary;
        }

        public void Extend(T list)
        {
            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();//for loop to print each index
        }

        //Make a method that temp holds the array that needs copied


    }
}
