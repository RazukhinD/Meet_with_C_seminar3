using static System.Console;

Clear();
Write("Введите номер дня недели: ");
int num1 = Convert.ToInt32(ReadLine()!);

switch (num1)
{
    case 1:
    {
        Write("Понедельник");
        break;
    }

    case 2:
    {
        WriteLine("Вторник");
        break;
    }
    case 3:
    {
        WriteLine("Среда");
        break;
    }
    case 4:
    {
        WriteLine("Четверг");
        break;
    }
    case 5:
    {
        WriteLine("Пятница");
        break;
    }
    case 6:
    {
        WriteLine("Суббота");
        break;
    }
    case 7:
    {
        WriteLine("Воскресение");
        break;
    }
    default:
    {
        Write("Введи правильный день недели");
        break;
    }
}