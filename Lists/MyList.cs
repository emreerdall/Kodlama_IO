using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class MyList<T>
    {
        public T[] mylist;

        public MyList()
        {
            mylist = new T[0];   
        }

        public void Add(T item)
        {
            T[] tempArray = mylist;
            mylist = new T[mylist.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                mylist[i] = tempArray[i];
            }
            mylist[mylist.Length-1] = item;
        }

        public int Count
        {
            get { return mylist.Length; }
        }

    }
}
