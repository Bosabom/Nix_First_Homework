using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_First_Homework
{
    abstract class Point
    {
        protected double x;
        protected double y;

        public double X 
        { 
            get 
            { 
                return x; 
            }
            set 
            {
               x = value;
            }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }

        }
        public abstract void Move(double dx, double dy);
        
        public virtual string Print()
        {
            return $"Координаты точки: X - {x}, Y - {y}";
        }
        public abstract void Scale(double k);// k - кратность масштабирования (увеличить/уменьшить фигур в несколько раз)
        
    }
}
