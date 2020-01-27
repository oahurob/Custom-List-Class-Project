using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class List<T>
    {
        public T[] list = new T[4];
        public int index;
        public int capacity; 
        public int Count { get { return count; } }
        private int count;

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public List()
        {
            index = 0;
            count = 0;
            capacity = 4;
        }

        public void EstablishList<T>()
        {
          
        }

        public void Add<T>(T list)
        {
            
        }

        public void Remove<T>(T list)
        {

        }

        public void Copy<T>(T list)
        {

        }

        public void Extend<T>(T list)
        {
            
        }

        //Make a method that temp holds the array that needs copied

    }
}
