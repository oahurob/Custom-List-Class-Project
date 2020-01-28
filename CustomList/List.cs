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
        //public T input;
        public int Count { get { return count; } }
        private int count;

        public T this[int index]
        {
            get
            {
                if (index < 0)//index > count - 1 || 
                {
                    throw new ArgumentOutOfRangeException();
                }
                return list[index];
            }
            set
            {
                if (index < 0)
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

        public void Add(T item)
        {
            if(count == capacity)
            {
                CopyList();
            }
            list[index] = item;
            index++;
            count++;
        }

        public bool Remove(T item)
        {
            bool Removed = false;

            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
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

            T[] tempList = new T[capacity];

            for (int i = 0; i < count - 1; i++)
            {
                tempList[i] = list[i];
            }
            list = tempList;
            return list;
        }

        public static List<T> operator +(List<T> one, List<T> two)
        {
            List<T> tempList = new List<T>();
            foreach(T item in one)
            {
                tempList.Add(item);
            }
            foreach(T item in two)
            {
                tempList.Add(item);
            }
            return tempList;
        }

        public static List<T> operator -(List<T> one, List<T> two)
        {
            // 1223
            // 482
            // 123
            // 13
            List<T> tempList = one;
            foreach(T item in two)
            {
                tempList.Remove(item);
            }
            return tempList;
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
