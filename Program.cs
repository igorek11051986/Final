string[] arr1;
Console.WriteLine("Введите массив строк через пробел");
string? s = Console.ReadLine();
arr1 = s.Split(' ');
//string[] arr1 = new string[4] {"Hello", "2", "world", ":-)"}; 
//string[] arr1 = new string[3] { "Russia", "Denmark", "Kazan" };
//string[] arr1 = new string[4] { "1234", "1567", "-2", "computer science" };
string[] arr2 = new string[arr1.Length];

void NewArray(string[] a, string[] b)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            b[count] = a[i];
            count++;
        }
    }
}
void PrintArray(string[] z)
{
    for (int i = 0; i < z.Length; i++)
    {
        Console.Write($"{z[i]} ");
    }
    Console.WriteLine();
}