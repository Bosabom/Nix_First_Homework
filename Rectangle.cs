using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_First_Homework
{
    class Rectangle : Point
    {
        //к левой верхней точке добавить ширину и высоту и получим нижнюю правую точку. Результат - прямоугольник.
        protected double width;//ширина
        protected double height;//высота
        
        //координаты правой нижней вершины прямоугольника
        protected double x2;
        protected double y2;
        
        public Rectangle(double _x1,double _y1,double _width, double _height)
        {
            X = _x1; //установка значения координаты 1 точки по иксам
            Y = _y1; //установка значения координаты 1 точки по игрикам
            width = _width;
            height = _height;
            x2 = x + width;
            y2 = y + height;
        }

        public override void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
            x2 += dx;
            y2 += dy;
        }
        public override void Scale(double K) {
            if (K > 0) //фигура увеличивается или уменьшается
            {
                width *= K;
                height *= K;
                x2 = x + width;
                y2 = y + height;
            }
            else 
            {
                Console.WriteLine("Неправильно введен коэффициент!");
            }
        }
        public override string Print()
        {
            return $"Координаты прямоугольника:\nлевая верхняя вершина({x} ; {y})\nправая нижняя вершина({x2} ; {y2})\n";
        }
    }
}
