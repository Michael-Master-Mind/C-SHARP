using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Ex1
{
    internal class Program
    {
        

        abstract public class Shape
        {
            public abstract double area();
            public abstract double perimeter();
        }
        public class Circle : Shape{
            static readonly double pi = 3.14;
            public double Raduis { get; set; }
            public override double area()
            {
                
                Console.Write("Enter radius of a circle to get the area:");
                double Raduis = double.Parse(Console.ReadLine());
                return pi *(Raduis * Raduis);
                
            }

            public override double perimeter()
            {
                Console.Write("Enter radius of a circle to get the parameter:");
                double Raduis= double.Parse(Console.ReadLine());
                double p=2 * pi * Raduis;
                return p;
               
            }
     
        }
        public class Rectangle : Shape {
            public double Width { get; set; }
            public double length { get; set; }
            public override double area()
            {
                Console.WriteLine("Enter the width of the rectangle: ");
                double Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the rectangle: ");
                double Length = double.Parse(Console.ReadLine());
                return Width * Length;
            }
            public override double perimeter()
            {
                Console.WriteLine("Enter the width of the rectangle to get the perimeter: ");
                double Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the rectangle to get the perimeter: ");
                double Length = double.Parse(Console.ReadLine());
                return 2 * (Width + Length);
            }
        }
        public class Triangle : Shape {
            public double basee { get; set; }
            public double hight { get; set; }
            public double x { get; set; }
            public double y{ get; set; }
            public double z{ get; set; }
        public override double area()
            {
                Console.WriteLine("Enter the BASE of the triangle to get the area: ");
                double basee = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the hight of the rectangle to get the area: ");
                double hight = double.Parse(Console.ReadLine());
                return (basee + hight)/2;
            }
            public override double perimeter()
            {
                Console.WriteLine("Enter the 'a' of the triangle to get the perimeter: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 'b' of the triangle to get the perimeter: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the hight of the triangle to get the perimeter: ");
                double z = double.Parse(Console.ReadLine());
                return x+y+z;
            }
        }

        static void Main(string[] args)
        {   string answer;
            string choice;
            string choice2;
        start:
            Console.WriteLine("Choose a Geometery");
            Console.WriteLine("-----------------------");
            Console.Write("1.Circle\n2.Rectangle\n3.Triangle\n\nchoice: ");
            choice = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Choose what to calculate");
            Console.Write("-----------------------\n");
            Console.Write("1.Area\n2.Perimeter\n\nchoice: ");
            choice2= Console.ReadLine();
            
            
            if (choice == "1") {
                Circle c = new Circle();
                    if (choice2 == "1")
                    {
                        Console.WriteLine("The area of a circle is: " + c.area());
                    }
                    else if (choice2 == "2") {
                        Console.WriteLine("The perimeter of a circle is: " + c.perimeter());
                    }else
                        Console.WriteLine("Error: you choice or entered the wrong input\nTry agian!!!");

            } else if (choice == "2") {
                Rectangle r = new Rectangle();
                    if (choice2 == "1")
                    {
                        Console.WriteLine("The area of a rectangle is: " + r.area());
                    }
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("The perimeter of a rectangle is: " + r.perimeter());
                    }
                    else
                        Console.WriteLine("Error: you choice or entered the wrong input\nTry agian!!!");

            } else if (choice == "3") {
                Triangle t = new Triangle();
                    if (choice2 == "1")
                    {
                        Console.WriteLine("The area of a triangle is: " + t.area());
                    }
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("The perimeter of a triangle is: " + t.perimeter());
                    }
                    else
                        Console.WriteLine("Error: you choice or entered the wrong input\nTry agian!!!\n");
            } else
                Console.WriteLine("Error: you choice or entered the wrong input\nTry agian!!!\n");

            do
            {
                
                Console.WriteLine("Do you want to continue(yes/no): ");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    goto start;
                }
                else
                    break;
            } while (answer == "no");
            Console.WriteLine("Bye!! Came back next time");
            Console.ReadKey();
            
        }
    }
    
}
