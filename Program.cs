string[] array1 = new string[4] {"111", "983", "ObiWan", "777"};
string[] array2 = new string[array1.Length];
void FirstArray(string[] array1, string[] array2)
{
      int count= 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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
FirstArray(array1, array2);
PrintArray(array2);