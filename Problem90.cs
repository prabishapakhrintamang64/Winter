using System;
namespace Application
{
    class Problem90
    {
        public static void solution()
        {
            Square p=new Square(12);
            float a= p.calculatePerimeter();
            Console.WriteLine(a);

            Circle q=new Circle(12.3);
            double b= q.calculatePerimeter();
            Console.WriteLine(b);

            Rectangle r=new Rectangle(12, 13);
             float s= r.calculatePerimeter();
            Console.WriteLine(s);

        }
      class Shapes
      {
         public float calculatePerimeter()
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
              public new float calculatePerimeter()
              {
               float Perimeter=4*length;
               return Perimeter;
              }
            }
            class Circle:Shapes
            {
              double radius;
              public Circle(double r)
              {
                this.radius=r;
              }

              public new double calculatePerimeter()
              {
                double Perimeter=2*3.14*radius;
                return Perimeter;
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
              public new float calculatePerimeter()
              {
               float Perimeter=2*length+breadth;
               return Perimeter;
              }
              
            }
            
    }
}
