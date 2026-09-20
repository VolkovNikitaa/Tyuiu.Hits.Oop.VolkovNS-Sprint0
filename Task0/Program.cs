/*Дан целочисленный массив numbers со следующими элементами { 5, 8, 1, 3, 9, 6, 7, 2 }, нужно выполнить следующие операции:

Найти минимальное и максимальное значения в массиве.
Найти сумму всех элементов массива.
Найти среднее арифметическое всех элементов массива.
Отсортировать массив в порядке возрастания.
Проверить, содержит ли массив определенное число.*/

// 1 пункт
int[] mass = { 5, 8, 1, 3, 9, 6, 7, 2 };

int max_num = mass.Max();
int min_num = mass.Min();

Console.WriteLine($"Минимальное число: {min_num}");
Console.WriteLine($"Максимальное число: {max_num}");


// 2 пункт
int sum = mass.Sum();
Console.WriteLine($"Сумма всех элементов массива: {sum}");

// 3 пункт
double mean = mass.Average();
Console.WriteLine($"Среднее арифметическое всех элементов: {mean}");

// 4 пункт
int[] sorted_mass = mass.OrderBy(n => n).ToArray();
Console.WriteLine("Отсортированный массив: " + string.Join(", ", sorted_mass));

// 5 пункт
int random_num = 3;
if (mass.Contains(random_num)){
    Console.WriteLine($"{random_num} есть в массиве");
}
else{
    Console.WriteLine($"{random_num} нет в массиве");
}