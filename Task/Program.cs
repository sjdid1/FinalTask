string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];

void DesiredArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
       if (arr1[i].Length <=3)
       {
        arr2[count] = arr1[i];
        count++;
       } 
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
DesiredArray(array1, array2);
PrintArray(array2);
