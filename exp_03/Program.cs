///123456 ///3

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());

int count=0;
int result=0;

if (number>=100)
{
    while (count<i)
    {
        // if (count<i+1)                            
        // {
        result=number/10;
        count++;
        // }
        // else
        // {
        //     Console.Write(result);
        //     break;
        // }
    }
    Console.Write(result);
            // break;
}
else
{
    Console.WriteLine("no");
}
