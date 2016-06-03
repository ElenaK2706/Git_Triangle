using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc_Triangle
{
    public class AreaTriangle
    {
        /*
         * Функция вычисляет площадь прямоугольного треугольника
         * Параметры - длины сторон треугольника
         * Возвращает площадь треугольника. Если возвращает 0 - неправильно введены параметры,
         * если -1 - треугольник не является прямоугольным
         * */
         
        public static double CalcAreaTriangle(double side1, double side2, double side3)
        {
            double area = 0;//площадь

            //проверяем, правильно ли введены стороны
            if (!((side1 > 0) && (side2 > 0) && (side3 > 0)))
                return 0;
            

            //проверяем, является ли треугольник прямоугольным
            
            //ищем гипотенузу и катеты
            double[] sides = new double[3];
              sides[0]=side1;
              sides[1]=side2;
              sides[2]=side3;
            Array.Sort(sides);//последний элемент - гипотенуза

            if (sides[0] == sides[2])
                return -1;//треугольник равнобедренный
              


            //Теорема Пифагора
            double hypotenuse2 = Math.Pow(sides[2], 2);//квадрат гипотенузы
            double cathetus = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);//сумма квадратов катетов

            if (hypotenuse2 != cathetus)
                return -1;//треугольник не прямоугольный

            area = 0.5 * sides[0] * sides[1];
            return area;

            
        }
    }
}
