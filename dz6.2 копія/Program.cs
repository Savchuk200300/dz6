using System;

namespace dz6._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IFigure figure = new Rectangle(10, 20);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Triangle(10,21,30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console.Read();
        }
    }
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        }
    }

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }


        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }
    class Triangle : IFigure
    {
        private int a;
        private int b;
        private int c;
        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b) <= c || (a + c) <= b || (b + c) <= a)
            {
                this.a = 0;
                this.b = 0;
                this.c = 0;

            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

        }
        public IFigure Clone()
        {

            return new Triangle(this.a, this.b, this.c);

        }
        public void GetInfo()
        {
            if (a != 0 && b != 0 && c != 0)
            {
                Console.WriteLine("Трикутник {0} | {1} | {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("Трикутник не існує");
            }
        }
    }
}
