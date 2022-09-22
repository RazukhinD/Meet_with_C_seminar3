using static System.Console;

Clear();
Write("Введите координату X первой точки: ");
double Xa = Convert.ToDouble(ReadLine()!);
Write("Введите координату Y первой точки: ");
double Ya = Convert.ToDouble(ReadLine()!);
Write("Введите координату Z первой точки: ");
double Za = Convert.ToDouble(ReadLine()!);
Write("Введите координату X второй точки: ");
double Xb = Convert.ToDouble(ReadLine()!);
Write("Введите координату Y второй точки: ");
double Yb = Convert.ToDouble(ReadLine()!);
Write("Введите координату Z первой точки: ");
double Zb = Convert.ToDouble(ReadLine()!);

double lenght = Math.Sqrt(Math.Pow(Xa-Xb,2)+Math.Pow(Ya-Yb,2)+Math.Pow(Za-Zb,2));

Write($"Длина заданного отрезка в пространстве {lenght:f2}");
