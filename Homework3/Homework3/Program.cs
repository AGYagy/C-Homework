using System;

namespace Homework3
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract void Initialization();
    }
    
    class Circle : Shape
    {
        double r;
        public Circle()
        {
            Initialization();
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override void Initialization()
        {
                string a = "";
                Console.WriteLine("请选择输入圆的半径：");
                a = Console.ReadLine();
                r = Int32.Parse(a);
        }
    }

    class Rectangle : Shape
    {
        double width;
        double length;
        public Rectangle()
        {
            Initialization();
        }

        public override double Area()
        {
            return width * length;
        }

        public override void Initialization()
        {
            string a = "";
            string b = "";
            Console.WriteLine("请选择输入矩形的宽：");
            a = Console.ReadLine();
            Console.WriteLine("请选择输入矩形的长：");
            b = Console.ReadLine();
            width = Int32.Parse(a);
            length = Int32.Parse(b);
        }
    }

    class Square : Shape
    {
        double width;
        public Square()
        {
            Initialization();
        }

        public override double Area()
        {
            return Math.Pow(width, 2);
        }

        public override void Initialization()
        {
            string a = "";
            Console.WriteLine("请选择输入正方形的边长：");
            a = Console.ReadLine();
            width = Int32.Parse(a);
        }
    }

    class Triangle : Shape
    {
        double height;
        double bottom;
        public Triangle()
        {
            Initialization();
        }

        public override double Area()
        {
            return bottom * height /2;
        }

        public override void Initialization()
        {
            string a = "";
            string b = "";
            Console.WriteLine("请选择输入三角形的高：");
            a = Console.ReadLine();
            Console.WriteLine("请选择输入三角形的底：");
            b = Console.ReadLine();
            height = Int32.Parse(a);
            bottom = Int32.Parse(b);
        }
    }

    class Factory
    {
        public static Shape CreateFunction(string name,double r,double width,double length,double height,double bottom)
        {
            switch (name)
            {
                case "1":return new Circle();
                    
                case "2":return new Rectangle();
                    
                case "3":return new Square();
                   
                default:return new Triangle();
                   
            }
        }

        internal static Shape CreateShape(string name)
        {
            throw new NotImplementedException();
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("请选择你要计算的图形，如下：");
        Console.WriteLine("1.圆 2.矩形 3.正方形 4.三角形");
        string name = Console.ReadLine();
        Shape shape = Factory.CreateShape(name);
        if (shape != null)
        {
            Console.WriteLine("面积为: ", shape.Area());
        }
        Console.ReadKey();
    }
}
