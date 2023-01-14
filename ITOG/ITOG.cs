//Забыл про коммиты сначала - извиняюсь заранее.
//Выполнение экзамеционной задачи. Спасибо за проведенные лекции команда GB
//ъуъ - Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
string[] array1 = new string[4] {"“Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
 {
    int co = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[co] = array1[i];
        co++;
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
SecondArrayWithIF(array1, array2);
PrintArray(array2);
