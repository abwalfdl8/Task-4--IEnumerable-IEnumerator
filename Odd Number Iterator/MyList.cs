using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Odd_Number_Iterator
{
    internal class MyList :IEnumerable
    {
        int[] arr;
        int CurrentIndex;
        public MyList()
        {
            arr = new int[5];
            CurrentIndex = -1;
        }

        public int Capacity()
        {
            return arr.Length;
        }

        public int Count()
        {
            return CurrentIndex + 1;
        }

        public void Add(int Num)
        {
           if(CurrentIndex == arr.Length-1) 
           {
             Extend();
           }
            arr[++CurrentIndex] = Num;
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
            if(index<0 || index>= Capacity())
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
            int index;
            public Iterator(MyList mylist)
            {
               this.mylist = mylist;
                index = -1;
            }

            public object Current
            {
                get
                {
                    return mylist.arr[index];
                }
            }
            public bool MoveNext()
            {
              
               while(++index <= mylist.CurrentIndex)
                {
                    if(mylist.arr[index]%2 != 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            public void Reset()
            {
                index = -1;
            }




        }





    }
}
