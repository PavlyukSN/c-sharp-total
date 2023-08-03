// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Сколько строк будет загружено? - ");
int mas = int.Parse(Console.ReadLine());
Console.Write("1 строка: ");
int count = 0;
string[] Arr = new string[mas];
string[] Out = new string[mas];
for (int i=0; i < Arr.Length; i++) 
{   
    Arr[i] = Console.ReadLine();
    if (Arr[i].Length < 4 ) {
        Out[count] = Arr[i];
        count++;
    }
    if(i < Arr.Length-1) Console.Write($"{i+2} строка: ");
}
Console.Write("Строки в 3 или меньше символов: ");
for (int i=0; i < count; i++)
{
    Console.Write(Out[i]);
    Console.Write(" ");
}
