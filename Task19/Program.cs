using static System.Console;

Clear();
WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(ReadLine());

if (number/100000!=0 || number/10000==0)
{
    Write("Вы ввели не пятизначное число");
    return;
}
int a0 = number%10;
int a1 = ((number-a0)/10)%10;
int a2 = ((number-a1*10-a0)/100)%10;
int a3 = ((number-a2*100-a1*10-a0)/1000)%10;
int a4 = number/10000;

if (a0==a4 && a1==a3)
{
    WriteLine("Число является полиндромом");
}
else
{
    WriteLine("Число не является полиндромом");
}
