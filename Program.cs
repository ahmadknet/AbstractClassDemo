using System;
namespace AbstractClass
{    
    abstract class Language
    {
        public abstract void display1();
        // non-abstract method
        public void display()
        {
            Console.WriteLine("Non abstract method");
        }
    }

    // inheriting from abstract class
    class Program : Language
    {
        public override void display1()
        {
            Console.WriteLine("Nsdson abstract method");
        }
        static void Main(string[] args)
        {
            
            // object of Program class
            Program obj = new Program();

            // access method of an abstract class
            obj.display1();

            Console.ReadLine();
        }
    }
}