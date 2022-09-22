using static System.Console;

Clear();
Write("Введите координату X первой точки: ");
double Xa = Convert.ToDouble(ReadLine()!);
Write("Введите координату Y первой точки: ");
double Ya = Convert.ToDouble(ReadLine()!);
Write("Введите координату X второй точки: ");
double Xb = Convert.ToDouble(ReadLine()!);
Write("Введите координату Y второй точки: ");
double Yb = Convert.ToDouble(ReadLine()!);

double lenght = Math.Sqrt(Math.Pow(Xa-Xb,2)+Math.Pow(Ya-Yb,2));

Write($"Длина заданного отрезка {lenght}");