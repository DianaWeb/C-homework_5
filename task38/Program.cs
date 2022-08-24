/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
	double[] array = new double[size];
	Random random = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = random.Next(leftRange, rightRange + 1);
	}
	return array;
}
double[] arr = FillArrayWithRandomNumbers(5, 0, 100);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

double findMaxNumber = FindMaxNumber(arr);
System.Console.WriteLine(findMaxNumber);

double findMinNumber = FindMinNumber(arr);
System.Console.WriteLine(findMinNumber);

double result = findMaxNumber - findMinNumber;
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}");

double FindMaxNumber(double[] arr)
{
	int i = 0;
	double maxNumber = arr[i];
	for (i = 0; i < arr.Length; i++)
	{
		if (arr[i] > maxNumber)
		{
			maxNumber = arr[i];
		}
	}
	return maxNumber;
}

double FindMinNumber(double[] arr)
{
	int i = 0;
	double minNumber = arr[i];
	for (i = 0; i < arr.Length; i++)
	{
		if (arr[i] < minNumber)
		{
			minNumber = arr[i];
		}
	}
	return minNumber;
}


