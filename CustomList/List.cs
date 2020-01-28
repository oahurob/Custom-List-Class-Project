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
            T[] tempList = new T[capacity];
            for (int i = 0, x = 1; i < count; i++, x++)
            {
                if (list[i].Equals(item))
                {
                    tempList[i] = list[x];
                    Removed = true;
                    count--;
                }
                else
                {
                    tempList[i] = list[i];
                }
            }
            list = tempList;
            return Removed;
        }

        public override string ToString()
        {
            StringBuilder listToString = new StringBuilder();
            for(int i = 0; i < count; i++)
            {
                listToString.Append(list[i]);
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
            for(int i = 0; i < one.Count; i++)
            {
                tempList.Add(one[i]);
            }
            for(int i = 0; i < two.Count; i++)
            {
                tempList.Add(two[i]);
            }
            return tempList;
        }

        public static List<T> operator -(List<T> one, List<T> two)
        {
            // 1223 // 482 // 123// 13
            List<T> tempList = one;
            for(int i = 0; i < two.Count; i++)
            {
                if(one[i].Equals(two[i]))
                {
                    tempList.Remove(one[i]);
                    tempList.Remove(two[i]);
                }
            }
            //foreach(T item in two)
            //{
            //    tempList.Remove(item);
            //}
            return tempList;
        }

        public static List<T> Zip(List<T> one, List<T> two)
        {
            List<T> temp = new List<T>();
            int count = 0;
            int counter = 0;

            while(count < two.Count + one.Count)
            {
                if (counter < one.Count)
                {
                    temp.Add(one.list[counter]);
                    count++;
                }
                if(counter < two.Count)
                {
                    temp.Add(two.list[counter]);
                    count++;
                }
                counter++;
            }
            return temp;
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
