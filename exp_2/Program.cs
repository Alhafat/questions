Console.Clear();

bool errorInput = true;
int inputNumber = 1;
while (errorInput)
{
    Console.Write("Введите трёхзначное число (100-999): ");
    inputNumber = int.Parse(Console.ReadLine());
    if (inputNumber < 100 || 999 < inputNumber)
    {
        errorInput = true;
        Console.Write("Ошибка ввода. ");
        continue;
    }
    else
        errorInput = false;
}
//                                   abc число. Искомое - b  = >   abc / 10 = ab    ab % 10 = b 
Console.Write($" Вы ввели число {inputNumber}. Искомая 2-a цифра: {(inputNumber / 10) % 10}");