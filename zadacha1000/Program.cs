// На вход подается не более 1000 чисел
// из отрезка [0; 100]
// Найти количество вхождений каждого числа

//int count = 1000;
//int[]data = int[count];

int[] Rs(int[] data)
{
    int[] count = new int[100 + 1];
    for (int i = 0; i < data.Length; i++) count[data[i]]++;
    return count;
}

int[] input = { 1, 1, 2, 2, 1, 1, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 1, 1, 1, 1 };
int[] result = Rs(input);

for (int i = 0; i < result.Length; i++)
{
    if (result[i] != 0)
    {
        //1 - 8 шт
        Console.WriteLine($"{i} - {result[i]} шт");
    }
}
