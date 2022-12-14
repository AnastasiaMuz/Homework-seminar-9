// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine ("Введите M");
int numberM = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите N");
int numberN = Convert.ToInt32 (Console.ReadLine());

int result = SumFromMToN (numberN, numberM);
Console.WriteLine(result);

int SumFromMToN (int n, int m)
{
    if(n<m) return 0;
    return n + SumFromMToN(n - 1, m);
}