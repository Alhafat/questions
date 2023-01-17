// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



while (true) 
{ 
    Console.Write("Введите первое число: "); 
    int a=int.Parse(Console.ReadLine()!); 
 
    Console.Write("Введите второе число: "); 
    int b=int.Parse(Console.ReadLine()!); 
        if (a==b) 
        { 
            Console.WriteLine($"Введите неравные числа!!!"); 
            continue; // Оператор возвращает в начало цикла. 
        } 
        else 
        { 
            Console.Write("Введите третье число: "); 
            int c=int.Parse(Console.ReadLine()!); 
            if ((c==a)^(c==b)) 
            { 
                Console.WriteLine($"Введите неравные числа!!!"); 
                continue; // Оператор возвращает в начало цикла.
            }
            else
            {
                if ((a>b)&(a>c))
                {
                    Console.WriteLine($"Максимальное число {a}"); 
                    break; 
                }
                else
                {
                    if (b>c)
                    { 
                        Console.WriteLine($"Максимальное число {b}"); 
                        break; 
                    } 
                    else
                    {
                        Console.WriteLine($"Максимальное число {c}");
                        break;
                    }

                }

            }
        } 
}    
// Тут не место для break... в Вашем контексте 
// break; 

// эта же задача чуть по другому, но работает!!!
// while (true)
// {
// Console.Write("Введите первое целое число: "); 
//    int firstInt = int.Parse(Console.ReadLine()!); 
//    Console.Write("Введите второе целое число: "); 
//    int secondInt = int.Parse(Console.ReadLine()!); 
//    // Alghafat: "если неравные давать третье для ввода" 
//    if (firstInt != secondInt) 
//    { 
//     Console.Write("Введите второе целое число: "); 
//     int thirdInt = int.Parse(Console.ReadLine()!); 
     
//     if (thirdInt != firstInt && thirdInt != secondInt) 
//     { 
//      int result = firstInt; 
//      if (result < secondInt) result = secondInt; 
//      if (result < thirdInt) result = thirdInt; 
//      Console.WriteLine($"Из введенных чисел: {firstInt}, {secondInt}, {thirdInt}; наибольшее  значение числа – {result}"); 
//     break; // Момотов Кирилл: "Результат получили, цикл прерываем" 
//     } 
//     else 
//     { 
//     Console.WriteLine("Первое число и второе число не должны быть равны!"); 
//     continue; // Момотов Кирилл: "Введены некорректные данные, идем на следующую итерацию" 
//     } 
//    } 
//    else 
//    { 
//     Console.WriteLine("Первое число и второе число не должны быть равны!"); 
//     continue; // Момотов Кирилл: "Введены некорректные данные, идем на следующую итерацию" 
//    } 
// }