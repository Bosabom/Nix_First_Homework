using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_First_Homework
{
    class Picture : Point 
    {

        private Point[] figures;
        
        public Picture()
        {
            figures = new Point[3];
        }
       
        public override string Print()
        {
           string outputt = figures[0].Print() + figures[1].Print() + figures[2].Print();
           return outputt;
        }
        public void AddRectangle(double X1, double Y1, double dX, double dY)
        {
            figures[0] = new Rectangle(X1,Y1,dX,dY);
        }
        public void AddCircle(double X1, double Y1, double radius)
        {
            figures[1] = new Circle(X1, Y1, radius);
        }
        public void AddTriangle(double X1, double Y1, double dX2, double dY2, double dX3, double dY3)
        {
            figures[2] = new Triangle(X1, Y1, dX2, dY2,dX3,dY3);
        }
        public override void Move(double dx, double dy)
        {
            foreach (var figure in figures)
            {
                figure.Move(dx,dy);
            }
        }
        public override void Scale(double k)
        {
            foreach(var figure in figures)
            {
                figure.Scale(k);
            }
        }
    }
}
