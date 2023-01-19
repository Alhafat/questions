///123456 ///3

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());

int count=0;
int result=number;

if (number>=100)
{
    while (count<i-1)
    {
        result=result/10;
        count=count+1;        
    }
    result=result%10;
    Console.Write(result);
}
else
{
    Console.WriteLine("no");
}