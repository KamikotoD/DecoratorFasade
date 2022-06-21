namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Dog dog = new Dog();
            person.Create();
            Console.WriteLine();
            dog.Create();
        }
    }
    public abstract class Сreature
    {
        public void Create()
        {
            Body();
            Hands();
            Legs();
            Head();
            TypeСreature();
        }
        protected abstract void Body();
        protected abstract void Hands();
        protected abstract void Legs();
        protected abstract void Head();
        protected virtual void TypeСreature()
        {
            Console.WriteLine("Created Сreature");
        }
    }
    public class Person : Сreature
    {
        protected override void Body()
        {
            Console.WriteLine("Created Body");
        }

        protected override void Hands()
        {
            Console.WriteLine("Created Hands");
        }

        protected override void Head()
        {
            Console.WriteLine("Created Head");
        }

        protected override void Legs()
        {
            Console.WriteLine("Created Legs");
        }
        protected override void TypeСreature()
        {
            Console.WriteLine("Created Person");
        }

    }
    public class Dog : Сreature
    {
        protected override void Body()
        {
            Console.WriteLine("Created Body");
        }

        protected override void Hands()
        {
            Console.WriteLine("Created front legs");
        }

        protected override void Head()
        {
            Console.WriteLine("Created Head");
        }

        protected override void Legs()
        {
            Console.WriteLine("Created hind legs");
        }
        protected override void TypeСreature()
        {
            Console.WriteLine("Created Dog");
        }

    }
}