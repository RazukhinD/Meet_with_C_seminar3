using static System.Console;

Clear();
WriteLine("Введи первое число: ");
int number = int.Parse(ReadLine()!);

if (number<0)
{
    Write("Введи число больше 0");
    return;
}
int i=1;
while (i<=number)
{
    Write($" {Math.Pow(i,2)}");
    i++;
}
