using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Кошка";
            cat.ShowInfo();

            Dog dog = new Dog();
            dog.Name = "Собака";
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("{0}", Name);
            Say();
        }
        public abstract string Name { get; set; }
    }
    class Cat : Animal
    {
        string name;
        public override void Say()
        {
            Console.WriteLine("говорит Мяу");
        }
        
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Dog : Animal
    {
        string name;
        public override void Say()
        {
            Console.WriteLine("говорит Гав");
        }
     
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
