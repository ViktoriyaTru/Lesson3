void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.WriteLine($"{e} ");
    }
}

int[] array = { 20, 2, 0, 4, 7 };

ZeroEvenElements(array);
PrintArray(array);