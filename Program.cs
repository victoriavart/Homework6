//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
int[] array = new int[5];
for (int i=0; i < array.Length; i++)
{
   Console.WriteLine(string.Format("Введите {0}й элемент массива:",i++));
   array[i] = Convert.ToInt32(Console.ReadLine());
}

int quantity = 0;

{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            quantity ++;
        }
    }
    Console.WriteLine(quantity);
}
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух 
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
{
{
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int k1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());

double x = 0;
double y = 0;

x = (b2 - b1) / (k1 - k2);  
y = k1 * x + b1;
Console.WriteLine($"{(x,y)}");
}
return 0;
}
*/