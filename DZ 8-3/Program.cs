using System;

namespace DZ_8_3
{
    class Person<T>
    {
        public T Age;
        public string Name;
        public Person(T age, string name)
        {
            Age = age;
            Name = name;
        }
        private void Print<T>() where T : 
        {

        }

    }

    class Programm
    {
        public static void Main()
        {
            Person<int> John = new Person<int>(20, "John");
            Person<string> Luffy = new Person<string>("19", "Luffy");
            Console.WriteLine(John.Age + " " + Luffy.Age);
        }
    }
}
