using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nix_First_Homework
{
    class Triangle : Rectangle
    {
        private double dx3;//смещение от 2 точки к 3 точке по ОХ
        private double dy3;//смещение от 2 точки к 3 точке по ОУ
        //координаты 3 точки
        private double x3;
        private double y3;

        public Triangle(double x1,double y1,double _dx2, double _dy2,double _dx3, double _dy3) : base(x1,y1,_dx2,_dy2) 
        {   
            dx3 = _dx3;
            dy3 = _dy3;
            x3 = x2 + dx3;
            y3 = y2 + dy3; 
        }
        public override void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
            x2 += dx;
            y2 += dy;
            x3 += dx;
            y3 += dy;
        }
        public override void Scale(double K)
        {
            if (K > 0)
            {
                width *= K;
                height *= K;
                dx3 *= K;
                dy3 *= K;
                //масштабирование относительно первой точки
                x2 = x + width;
                y2 = y + height;
                x3 = x2 + dx3;
                y3 = y2 + dy3;       
            }
        }
        public override string Print()
        {
            return $"Координаты вершин треугольника:" +
                $"\n1-ая вершина ({x} ; {y})\n" +
                $"2-ая вершина ({x2} ; {y2})\n" +
                $"3-я вершина ({x3} ; {y3})\n)";
        }
    }

}
