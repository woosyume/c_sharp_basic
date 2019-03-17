using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person("panda", 20);
            Console.WriteLine(person.Age);

            person = new Person("lion");
            Console.WriteLine(person.Age);

            // Deconstructor
            DeconstTest deconst = new DeconstTest();
            Console.WriteLine("-----");

            deconst = null;

            Console.WriteLine("3\n");
            Console.WriteLine("-----");
        }
    }

    class A
    {
        readonly int num;

        public A(int num)
        {
            this.num = num;
        }

        public void Method(int num)
        {
            int x = this.num;
            //this.num = num; cannot change this value. it's readonly.
        }
    }

    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public Person(string Name) : this(Name, 99)
        {

        }
    }

    class DeconstTest
    {
        public DeconstTest()
        {
            Console.WriteLine("create instance.");
        }

        ~DeconstTest()
        {
            Console.WriteLine("remove instance.");
        }
    }
}
