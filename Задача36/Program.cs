//Задача 36: Задайте одномерный массив,
//заполненный случайными числами. 
//Найдите сумму элементов,
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count (int[] numbers)
{
int sum = 0;
int j = 0;
while (j < numbers.Length)
{
sum = sum + numbers[j];
j = j + 2;
}
return sum;
}
Console.WriteLine($"сумма элементов на нечётных позициях = {count(numbers)}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}