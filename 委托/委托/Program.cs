using System;

namespace 委托
{
    class Program
    {
        //确定语言了类型
        public enum Language
        {
            English,Chines
        }

        public static void Greet_People(string name,Language lang)
        {
            switch (lang)
            {
                case Language.English:
                    English_Greeting(name);
                    break;
                case Language.Chines:
                    Chinese_Greeting(name);
                    break;
            }
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
            Greet_People("Tank", Language.English);
            Greet_People("李梅梅", Language.Chines);
            Console.ReadLine();

        }
    }
}
