using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_First_Homework
{
    class Circle : Point
    {
        private double r;//радиус
        
        public Circle(double _x1,double _y1,double _radius)
        {
            X = _x1;
            Y = _y1;
            r = _radius;   
        }
        public override void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        public override void Scale(double k)
        {
            if (k > 0)
            {
                r *= k;
            }
        }
        public override string Print()
        {
            return $"Круг:\nцентр круга в точке ({x} ; {y})\nрадиус = {r}\n";
        }
    }
}
