using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class List<T>
    {
        T[] list;
        public int count;

        public void EstablishList<T>(T list) where T: List, new()
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
