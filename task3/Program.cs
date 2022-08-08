string[] week = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=1 & a<=7)
{
Console.WriteLine(week[a-1]);
}
else
{
    Console.WriteLine("Неверное число");
}