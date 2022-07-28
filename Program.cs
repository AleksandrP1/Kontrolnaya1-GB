// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.WriteLine(array[i]);
    }
}

Console.WriteLine("Введите число строк в массиве: ");
int m = int.Parse(Console.ReadLine());

string [] mass = new  string[m];

for (int j = 0; j < mass.Length; j++)
{
    Console.WriteLine($"Введите строку {j+1} из любых символов (лучше не больше 4 символов): ");
    mass[j] = Console.ReadLine();
}
Console.WriteLine("Исходный массив строк: ");
Print(mass);
Console.WriteLine();


int t = 0; // счетчик для определения размера нового массива
int s = 3;  // максимальное количество символов в строке исходного массива, чтобы эта строка попала в новый массив

for (int j = 0; j < mass.Length; j++)
{
    if (mass[j].Length <= s)
    {
        t++;
    }
}
Console.WriteLine("Размер нового массива (= количество строк): " + t);

string [] second = new  string[t];
int r = 0;

for (int j = 0; j < mass.Length; j++)
{
    if (mass[j].Length <= s)
    {
        second[r] = mass[j];
        r ++;
    }
}
Console.WriteLine("Новый массив строк: ");
Print(second);