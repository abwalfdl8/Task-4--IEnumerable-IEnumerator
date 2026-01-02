namespace Odd_Number_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList mylist = new MyList() {1,2,3,4,5,6,7,8,9,10};

            foreach (int n in mylist)
            {
              Console.WriteLine(n);
            }




        }
    }
}
