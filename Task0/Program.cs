using static System.Console;

Clear();
Write("Введите координату X: ");
int x = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y: ");
int y = Convert.ToInt32(ReadLine()!);
if (x==0 || y==0)
{
    WriteLine("Error");  
    return;
}
if (x>0 && y>0)
{
    WriteLine("1 четверть");  
}
if (x<0 && y>0)
{
    WriteLine("2 четверть");
}
if (x<0 && y<0)
{
    WriteLine("3 четверть");
}
if (x>0 && y<0)
{
    WriteLine("4 четверть");
}
