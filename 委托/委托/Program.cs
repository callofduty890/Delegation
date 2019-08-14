using System;

namespace 委托
{
    //定义了一个委托
    public delegate void GreetingDelegate(string name);

    class Program
    {

        public static void Greet_People(string name,GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }

        public static void English_Greeting(string name)
        {
            Console.WriteLine("Hello World! " + name);
        }

        public static void Chinese_Greeting(string name)
        {
            Console.WriteLine("你好世界 " + name);
        }

        static void Main(string[] args)
        {
            Greet_People("Tank", English_Greeting);
            Greet_People("李梅梅", Chinese_Greeting);
            Console.ReadLine();

        }
    }
}
