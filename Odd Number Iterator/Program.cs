using System.Collections;

namespace Odd_Number_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);

            //IEnumerator enumerator = myList.GetEnumerator();

            //while(enumerator.MoveNext())
            //{
            //   int OddNumber= (int)enumerator.Current;
            //    Console.WriteLine(OddNumber);
            //}


            foreach (int OddNumber in myList)
            {
                Console.WriteLine(OddNumber);
            }




        }
    }
}
