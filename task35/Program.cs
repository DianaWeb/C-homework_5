/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5 */
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
int[] arr = FillArrayWithRandomNumbers(123, 0, 999);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

int countNumber = quantityNumbersInArray(arr);
System.Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {countNumber}");

int quantityNumbersInArray(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] >= 10 & array[i] <= 99)
		{
			count++;
		}
	}
	return count;
}