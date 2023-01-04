// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int  [] CreateArray(int size, int min, int max)
// {
//     int [] array = new int[size];
//     for(int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int [] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int [] ReverseArray(int [] array)
// {
//     int l = array.Length;
//     for (int i = 0; i < l/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[l - 1 - i];
//         array[l - 1 - i] = temp;
//     }
//     return array;
// }

// Console.Write ("Enter array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Enter min element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Enter max element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// int [] revArray = ReverseArray(array);
// ShowArray(revArray);



// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int  [] Array(int num)
// {
//     int count = 0;
//     int temp = num;
//     while(num != 1)
//     {
//         temp/=2;
//         count++;

//     }
//     int [] array = new int [count];
//     for(int i = 0; i<count; i++)
//     {
//         Console.Write($"{num%2} ");
//         array[count-1-i] = num%2;
//         num/=2;
//     }
//     return array;
// }

// Console.Write ("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int mass = [] Array (num);



//  2 способ - лучший

// string BinarySystem (int num)
// {
//     string result = string.Empty;
//     while (num != 0)
//     {
//         result =  num % 2 + result;
//         num = num / 2; 
//     }
//     return result;
// }

// Console.Write ("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string array = BinarySystem(num);
// Console.WriteLine(array);


//  Напишите программу, 
//которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// bool Triangle(int a, int b,int c)
// {
//     bool flag = false;
//     if(a+b >c && b+c>a && a+c>b)
//         flag = true;
// return flag;
// }

// Console.Write ("Enter a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Enter b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Enter c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// bool flag = Triangle(a,b,c);
// Console.WriteLine(flag);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1

// void Fibonacci(int n)
// {
//     int [] array = new int[n];
//     array[0]= 0;
//     array[1] = 1;
//     for(int i=2; i<n; i++)
//     {
//         array[i] = array[i-1]+array[i-2];
//     }
//     ShowArray(array);
// }

// void ShowArray(int [] array)
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Fibonacci(n);

// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: любые.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1

void Fibonacci(int n, int num1, int num2)
{
    int [] array = new int[n];
    array[0]= num1;
    array[1] = num2;
    for(int i=2; i<n; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    ShowArray(array);
}

void ShowArray(int [] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Input size: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Fibonacci(n, num1, num2);