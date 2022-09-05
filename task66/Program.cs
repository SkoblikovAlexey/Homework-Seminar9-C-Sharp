// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Number(int M, int N)
{
    int result = 0;
    if(M <= N) return result += M + Number(M + 1, N);
    else return 0;
}

Console.WriteLine(Number(1, 15));