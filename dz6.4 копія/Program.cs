using System;
namespace FactoryMethodExample
{

    public abstract class Creator
    {
        public abstract Product FactoryMethod(int type);
    }

    public abstract class Product {

        public abstract void Info();

        public abstract void Create();
    }


    public class TransFactory : Creator
    {
        public override Product FactoryMethod(int type)
        {
            return type switch
            {
                1 => new Car(),
                2 => new Plane(),
                3 => new Train(),
                _ => throw new ArgumentException("Invalid type."),
            };
        }

    }

    public class Car : Product
    {
        private int speed;

        private string engine;

        public Car()
        {
            speed = 320;
            engine = "CarEngine: 4.4";
            Info();
            Create();
        }

        public override void Info()
        {
            Console.WriteLine("Car with {0} - speed, {1} - engine", speed, engine);
        }

        public override void Create()
        {
            Console.WriteLine("It is possible to create a Car");
        }
    }


    public class Plane : Product
    {
        private int speed;

        private string engine;

        public Plane()
        {
            speed = 1000;
            engine = "PlaneEngine: 40.3";
            Info();
            Create();
        }

        public override void Info()
        {
            Console.WriteLine("Plane with {0} - speed, {1} - engine", speed, engine);
        }

        public override void Create()
        {
            Console.WriteLine("It is possible to create a Plane");
        }
    }

    public class Train : Product
    {
        private int speed;

        private string engine;

        public Train()
        {
            speed = 500;
            engine = "PlaneEngine: 10.3";
            Info();
            Create();
        }

        public override void Info()
        {
            Console.WriteLine("Plane with {0} - speed, {1} - engine", speed, engine);
        }

        public override void Create()
        {
            Console.WriteLine("It is possible to create a Plane");
        }
    }
    class FactoryMethod
    {
        static void Main()
        {
            Creator creator = new TransFactory();
            for (int i = 1; i <= 3; i++)
            {
                var product = creator.FactoryMethod(i);
                Console.WriteLine("Transport id = {0}, Created {1} \n", i, product.GetType());
            }
            Console.ReadKey();
        }
    }
}
