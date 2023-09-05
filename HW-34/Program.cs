// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Рабочий массив: ");
PrintArray(numbers);
ArrayChet();

void ArrayChet()
{
    int count = 0;
    for (int z = 0; z < numbers.Length; z++)
        if (numbers[z] % 2 == 0)
            count++;
    Console.WriteLine($"Массив из {numbers.Length} чисел. В нём {count} чётных чисел");
}

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(100, 1000);
        }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}