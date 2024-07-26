using System;
namespace Application
{
    class Problem89
    {
        public static void solution()
        {
            Square p=new Square(12);
            float a= p.calculateArea();
            Console.WriteLine(a);

            Circle q=new Circle(12.3);
            double b= q.calculateArea();
            Console.WriteLine(b);

            Rectangle r=new Rectangle(12, 13);
             float s= r.calculateArea();
            Console.WriteLine(s);

        }
          class Shapes
          {
            public float calculateArea()
            {
                return 0;
            }


          }
           class Square:Shapes
           {
              float length;
              public Square(float l)
              {
                this.length=l;
              }
              public new float calculateArea()
              {
               float Area=length*length;
               return Area;
              }
            }
            class Circle:Shapes
            {
              double radius;
              public Circle(double r)
              {
                this.radius=r;
              }

              public new double calculateArea()
              {
                double Area=3.14*Math.Pow(radius,2);
                return Area;
              }
            }
           class Rectangle:Shapes
           { 
              float length;
              float breadth;
              public Rectangle(float l, float b)
              {
                this.length=l;
                this.breadth=b;
              }
              public new float calculateArea()
              {
               float Area=length*breadth;
               return Area;
              }
              
            }
            
    }
}