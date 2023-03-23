/* Написать программу, которая из имеющегося массива строк формирует массивиз строк, 
длинна которых меньше либо равна трём символам. Первоначальный массивможно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */

//методы

string[] Fillarr()
{
    Console.WriteLine("Введеите эллементы массива в строку разделяя запятой и пробелом");
    string stringElements = Console.ReadLine();
    string[] str = stringElements.Split(", ");
    return str;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.WriteLine("]");
}

string[] CreateNewArr(string[] str, int mLength)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= mLength) count++;
    }
   
    string[] newStr = new string[count];
    int j =0;
    for (int i = 0; i < str.Length; i++)
    {
           if (str[i].Length <= mLength) 
           {
            newStr[j] = str[i];
            j++;
           }           
    }
    
   
    return newStr;
}

//программа

string[] array = Fillarr();
int maxLength =3;
string[] newArray = CreateNewArr(array, maxLength);
PrintArray(array);
PrintArray(newArray);