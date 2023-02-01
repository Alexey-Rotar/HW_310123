// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Метод вычисления координат пересечения
(float, float, bool) GetCrossPoint (float k1, float b1, float k2, float b2)
{
    float x=0;
    float y=0;
    bool parallel=false;
    if (!(k1==k2))
    {
        x = (b2-b1)/(k1-k2);
        y = k1*x+b1;
    }
    else
    {
        Console.WriteLine($"Линии параллельны. Точки пересечения нет.");
        parallel=true;
    }
    return (x, y, parallel);    
}

// Интерфейс
Console.WriteLine("y = k1*x + b1;");
Console.WriteLine("y = k2*x + b2;"); 
Console.WriteLine("Введите коэффициенты:");

Console.Write("k1: ");
float k1;
while (!float.TryParse(Console.ReadLine(), out k1))
{
    Console.WriteLine("Некорректное значение!");            
}

Console.Write("b1: ");
float b1;
while (!float.TryParse(Console.ReadLine(), out b1))
{
    Console.WriteLine("Некорректное значение!");            
}

Console.Write("k2: ");
float k2;
while (!float.TryParse(Console.ReadLine(), out k2))
{
    Console.WriteLine("Некорректное значение!");            
}

Console.Write("b2: ");
float b2;
while (!float.TryParse(Console.ReadLine(), out b2))
{
    Console.WriteLine("Некорректное значение!");            
}


(float x, float y, bool parallel) = GetCrossPoint(k1, b1, k2, b2);

Console.WriteLine("Полученные уравнения:");        
Console.WriteLine($"y = {k1}x + {b1};");
Console.WriteLine($"y = {k2}x + {b2};");

if (!parallel) 
Console.WriteLine($"Координаты точки пересечения: ({x}, {y})");