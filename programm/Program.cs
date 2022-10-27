string[] startArray = new string[] {"hello", "2", "world", "=)", "1234", "1567", "-2", "computer science"};
string[] resultArray = new string[startArray.Length];

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string[] FilterArray(string[] array)
{
      
    int count = 0;     //счетчик количества строк  
    int maxLen = 3;    //переменная для обозначения максимальной длины строки
    for (int i = 0; i < array.Length; i++)  //Перебираем все элементы массива 
    {
        if ((array[i]).Length <= maxLen)    //считаем только те элементы, длина которых не больше максимальной длины строки
        {
            count++;                        // определение длины нового массива
        }
            
    }
       
    string[] resArray = new string[count];  //Задаем новый массив строк, состоящий из count элементов
    int j = 0;
    for (int i = 0; i < array.Length; i++)  //Переносим в новый массив те строки, длина которых не превышает максимальную длину строки
    {
        if ((array[i]).Length <= maxLen)
        {
            resArray[j] = array[i];
            j++;
        }
    }
    return resArray;
}

Console.Write("Начальный массив: ");
PrintArray(startArray);
resultArray = FilterArray(startArray);
Console.WriteLine();
Console.Write("Результат выполнения программы: ");
PrintArray(resultArray);