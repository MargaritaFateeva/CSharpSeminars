﻿// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x+b1=k2*x+b2 -> (k1-k2)*x = b2-b1 -> x = (b2-b1)/(k1-k2) y=k1*(b2-b1)/(k1-k2)+b1

void GetPoint (double k1, double b1, double k2, double b2)
{  
    double x = (b2-b1)/(k1-k2);
    double y = k1*(b2-b1)/(k1-k2)+b1;
    Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x}; {y})");
    if (k1==k2 && b1==b2) 
    {
        Console.WriteLine("Прямые совпадают, точки пересечения вся прямая");
    }
    if (k1==k2 && (b1>b2 || b1<b2)) 
    {
        Console.WriteLine("Прямые не пересекаются, точек пересечения нет");
    }
}

GetPoint(5,2,9,4);