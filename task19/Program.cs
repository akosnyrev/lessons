
Console.WriteLine("Введите пятизначное число");
bool flag=false;
int num = Convert.ToInt32(Console.ReadLine());
while (flag==false)
{
    
    if (5==Convert.ToString(num).Length )
        {
            flag=true;
        }
        else
        {
            Console.WriteLine("Введено не пятизначное число, повторите ввод:");
            num = Convert.ToInt32(Console.ReadLine());
        }
}
string str=Convert.ToString(num);
if ((str[0]==str[4])&(str[2]==str[3]))
    {
        Console.WriteLine("Число - полиндром");
    }
    else
    {
        Console.WriteLine("Число - не полиндром");
    }
