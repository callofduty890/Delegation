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
            //委托调用
            Greet_People("Tank", English_Greeting);
            Greet_People("李梅梅", Chinese_Greeting);
            Console.WriteLine("======================================");

            //绑定多个事件--【方法一】
            GreetingDelegate delegate1;
            //绑定事件一
            delegate1 = English_Greeting;
            //绑定事件二
            delegate1 += Chinese_Greeting;
            //调用
            Greet_People("韩梅梅", delegate1);

            Console.WriteLine("======================================");

            //绑定多个事件--【方法二】
            //绑定事件一
            GreetingDelegate delegate2 = new GreetingDelegate(English_Greeting);
            //绑定事件二
            delegate2 += Chinese_Greeting;
            //调用
            Greet_People("韩梅梅", delegate2);

            Console.WriteLine("======================================");

            //取消事件绑定
            //取消绑定事件一
            delegate2 -= English_Greeting;
            //调用
            Greet_People("龙傲天", delegate2);
            Console.ReadLine();

        }
    }
}
