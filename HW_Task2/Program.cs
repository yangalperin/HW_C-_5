// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = ReadInt("Введите число b1: ");
double k1 = ReadInt("Введите число k1: ");
double b2 = ReadInt("Введите число b2: ");
double k2 = ReadInt("Введите число k2: ");

// y = k1 * x + b1
// y = k2 * x + b2
// k1x + b1 = k2x + b2 
// k1x - k2x = b2 - b1
// x * (k1 - k2) = b2 - b1 

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if(b1 == b2 && k1 == k2)
{
    Console.Write("Прямые совпадают ");
}
else if(k1 == k2)
{
    Console.Write("Параллельные прямые ");
}

else 
{
   
    Console.Write("Координаты точки пресечения прямых: " + x + " " + y);
}


double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
