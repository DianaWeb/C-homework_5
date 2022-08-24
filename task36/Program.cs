/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0 */
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
int[] arr = FillArrayWithRandomNumbers(4, 0, 100);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

int sum = sumNumbers(arr);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");

int sumNumbers(int[] array)
{
	int sum = 0;
	for (int i = 1; i < array.Length; i += 2)
	{
		sum = sum + array[i];
	}
	return sum;
}