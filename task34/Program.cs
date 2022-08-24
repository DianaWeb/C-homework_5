/* Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
	int[] array = new int[size];
	Random random = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = random.Next(leftRange, rightRange + 1);
	}
	return array;
}
int[] arr = FillArrayWithRandomNumbers(10, 100, 999);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

int countNumber = quantityEvenNumbersInArray(arr);
System.Console.WriteLine($"Количество четных чисел в массиве: {countNumber}");

int quantityEvenNumbersInArray(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			count++;
		}
	}
	return count;
}
