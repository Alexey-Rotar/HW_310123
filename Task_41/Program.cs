// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Создание массива
float[] CreatingArray(int size)
{
    float[] array = new float[size];
    return array;
}

// Заполонение значениями
float[] FillingArray(float[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        float value;
        while (!float.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Некорректное значение!");             
        }  
        array[i] = value;
    }
    return array;
}

// Метод посчета значений > 0
int GetAboveZeroValues(float[] array)
{
    int zeroCount = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] > 0)
            zeroCount++;        
    }
    return zeroCount;    
}

// Интерфейс
Console.WriteLine("Сколько значений будет введено?");
int size;
while (!int.TryParse(Console.ReadLine(), out size) || size==0)
{
    Console.WriteLine("Некорректное значение!");            
}
Console.WriteLine("Введите значения:");

Console.WriteLine($"Значений больше нуля: {GetAboveZeroValues(FillingArray(CreatingArray(size)))}");