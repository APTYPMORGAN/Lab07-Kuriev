// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// double[] temps = { 20, 15, 8, 5, -5, -2, 0 };

// foreach (double temp in temps)
// {
//     Console.Write($"{temp} ");
// }


// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int counter = 0;

// foreach (int price in prices) {
//     sum += price;
//     if (price > 100) {
//         counter++;
//     }
// }

// double average = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}, среднее: {average}, Товаров дороже 100: {counter}");


// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int index_max = 0;

// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//         if (prices[i] > max)
//     {
//         max = prices[i];
//         index_max = i;
//     }
// }
// Console.WriteLine($"Минимальный элемент = {min}");
// Console.WriteLine($"Индекс максимального элемента = {index_max}");


// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }

// foreach (int n in balance)
// {
//     Console.Write(n + " ");
// }


// int[] numbers = new int[5];
// int counter = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write("Введите число: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
//     if (numbers[i] % 2 == 0)
//     {
//         counter++;
//     }
// }
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine("");
// Console.WriteLine($"Чётных чисел в массиве: {counter}");


// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя: ");
// string name = Console.ReadLine();
// bool flag = true;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == name)
//     {
//         Console.WriteLine($"Имя {name} стоит на {i} месте");
//         flag = false;
//     }
// }
// if (flag)
// {
//     Console.WriteLine("Не найдено");
// }


// int[] grades = { 3, 5, 4, 5, 2, 5, 5, 4 };
// double average;
// int sum = 0;
// int min = grades[0], max = grades[0];
// int counter_2 = 0, counter_5 = 0;
// foreach (int grade in grades) {
//     Console.Write(grade + " ");
//     sum += grade;
//     if (grade > max) {
//         max = grade;
//     }
//     if (grade < min) {
//         min = grade;
//     }
//     if (grade == 2) {
//         counter_2++;
//     }
//     if (grade == 5) {
//         counter_5++;
//     }
// }
// average = (double)sum / grades.Length;
// Console.WriteLine("");
// Console.WriteLine($"Средняя оценка = {average}");
// Console.WriteLine($"Наибольшая оценка - {max}, а наименьшая - {min}");
// Console.WriteLine($"Двоек в списке: {counter_2}, а пятёрок: {counter_5}");
// if (average >= 4.5) {
//     Console.WriteLine("Отличник");
// }
// else if (average >= 3.5) {
//     Console.WriteLine("Хорошист");
// } else {
//     Console.WriteLine("Есть над чем поработать");
// }


int[] arr = { 1, 2, 3, 4, 5, 6 };
int counter = 0;
for (int i = 0; i < 3; i++)
{
    int temp = arr[i];
    arr[i] = arr[5 - counter];
    arr[5 - counter] = temp;
    counter++;
}
foreach (int ar in arr)
{
    Console.Write(ar + " ");
}