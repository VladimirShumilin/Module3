using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";
            const int MyAge = 27;
            const bool IHavePet = true;
            const double ShoeSize = 37.5d;

            Console.WriteLine(MyName);

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + IHavePet);
            Console.WriteLine("My shoe size is " + ShoeSize);


            Console.ReadKey();
        }
    }
}
