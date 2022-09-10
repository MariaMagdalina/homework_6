﻿// Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите коэффициенты: b1= ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1= ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2= ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2= ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2) // проверяем условие совпадения прямых
   Console.WriteLine("Прямые совпадают и имеют бесконечное множество точек пересечения");
else
   if(k1 == k2) // проверяем условие параллельности прямых
      Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
   else
     {
         double y = (b2*k1 - b1*k2)/(k1 - k2); // находим координаты x и y точки пересечения прямых
         double x; 
         if(k1 != 0) // т.к. на 0 делить нельзя
           {
            x = (y - b1) / k1;
           }
         else 
           {
            x = (y - b2) / k2;
           }
         Console.WriteLine("Прямые пересекаются в точке с координатами: " + x + "; " + y);
     }
