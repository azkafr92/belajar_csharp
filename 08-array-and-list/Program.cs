// array
int[] numbers1 = [1, 2, 3, 4, 5];
for (int i = 0; i < numbers1.Length; i++)
{
    Console.Write(numbers1[i]);
}
Console.Write("\n");

numbers1 = [.. numbers1, 6];
for (int i = 0; i < numbers1.Length; i++)
{
    Console.Write(numbers1[i]);
}
Console.Write("\n");

numbers1 = numbers1[..(numbers1.Length - 2)];
for (int i = 0; i < numbers1.Length; i++)
{
    Console.Write(numbers1[i]);
}
Console.Write("\n");

// List
List<int> numbers2 = [6, 7, 8, 9, 10];
foreach (int number in numbers2)
{
    Console.Write(number);
    Console.Write(" ");
}
Console.Write("\n");
