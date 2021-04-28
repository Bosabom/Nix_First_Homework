using System;

namespace Nix_First_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Picture pic = new Picture();
            Console.WriteLine("Задайте параметры прямоугольника (дробные числа указывать через ',':");
            Console.WriteLine("Координаты левой верхней точки по осям Ox и Oy:");
            try
            {   //прямоугольник
                double X1 = Convert.ToDouble(Console.ReadLine());
                double Y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ширину и высоту:");
                double Dx = Convert.ToDouble(Console.ReadLine());
                double Dy = Convert.ToDouble(Console.ReadLine());

                pic.AddRectangle(X1, Y1, Dx, Dy);
                
                //круг
                Console.WriteLine("Задайте параметры круга:");
                Console.WriteLine("Координаты центра круга по осям Ox и Oy:");
                double X_circle = Convert.ToDouble(Console.ReadLine());
                double Y_circle = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Радиус:");
                double circle_radius = Convert.ToDouble(Console.ReadLine());

                pic.AddCircle(X_circle, Y_circle, circle_radius);

                //Треугольник
                Console.WriteLine("Задайте параметры треугольника:");
                Console.WriteLine("Координаты 1-ой точки по осям Ox и Oy:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Смещение от 1-ой точки по осям Ox и Oy: ");
                double dx2 = Convert.ToDouble(Console.ReadLine());
                double dy2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Смещение от 2-ой точки по осям Ox и Oy: ");
                double dx3 = Convert.ToDouble(Console.ReadLine());
                double dy3 = Convert.ToDouble(Console.ReadLine());

                pic.AddTriangle(x1, y1, dx2, dy2, dx3, dy3);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine(pic.Print());
            Console.WriteLine("==================================");
            Console.WriteLine("1 - перемещение изображения,\n2 - масштабирование изображения\n3 - выход");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Укажите 2 значения, насколько нужно сместить (по Ox и Oy)");
                    double DX= Convert.ToDouble(Console.ReadLine());
                    double DY = Convert.ToDouble(Console.ReadLine());
                    pic.Move(DX, DY);
                    Console.WriteLine(pic.Print());
                    break;
                case 2:
                    Console.WriteLine("Во сколько раз нужно масштабировать?\n(для уменьшения введите значения в промежутке (0,1)");
                    double scaling = Convert.ToDouble(Console.ReadLine());
                    pic.Scale(scaling);
                    Console.WriteLine(pic.Print());
                    break;
                case 3:
                    Console.WriteLine("Всего доброго!");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод!");
                    break;
            }

        }
    }
}
