using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Odd_Number_Iterator
{
    internal class MyList :IEnumerable
    {
        int[] arr;
        int LastIndex;
        public MyList()
        {
            arr = new int[5];
            LastIndex = -1;
        }

        public int Capacity()
        {
            return arr.Length;
        }

        public int Count()
        {
            return LastIndex + 1;
        }

        public void Add(int Num)
        {
           if(LastIndex == arr.Length-1) 
           {
             Extend();
           }
            arr[++LastIndex] = Num;
        }
        private void Extend()
        {
            int[] newArr = new int[arr.Length*2];
            
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        public int GetByIndex(int index)
        {
            if(index<0 || index >= Capacity())
            {
               throw new IndexOutOfRangeException();
            }
            return arr[index];
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            MyList mylist;
            int CurrentIndex;
            public Iterator(MyList mylist)
            {
               this.mylist = mylist;
                CurrentIndex = -1;
            }

            public bool MoveNext()
            {
               while(++ CurrentIndex < mylist.LastIndex)
                {
                    if(mylist.arr[CurrentIndex]%2 != 0)
                    {
                        return true;
                    }
                }
                return false;
            }


            public object Current
            {
                get
                {
                    return mylist.arr[CurrentIndex];
                }
            }
            public void Reset()
            {
                CurrentIndex = -1;
            }




        }





    }
}
