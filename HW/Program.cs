//Функция печати массива
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == (arr.Length-1))
            Console.Write($"{arr[i]}");
        else
            Console.Write($"{arr[i]}, ");
    }
}

//Функция заполнения массива из случайного числа с 1 до 15
void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GenerateString(new Random().Next(1, 15));
    }
}


//Функция формирования строки
string GenerateString(int strLenth)
{
    string word = "";
    string[] arr = { "1","2","3","4","5","6","7","8","9","B","C","D","F","G","H","J","K","L","M","N","P","Q","R","S","T","V","W","X","Z","b","c","d","f","g","h","j","k","m","n","p","q","r","s","t","v","w","x","z","A","E","U","Y","a","e","i","o","u","y","*","-","+","/","?",",","." };
    Random rnd = new Random();
    for (int i = 0; i < strLenth; i = i + 1)
    {
        word = word + arr[rnd.Next(0, 65)];
    }
    return word;
}

//Функция формирует массив из имеющегося массива строк длина которых меньше или равна 3
string[] CutArray(string[] arr)
{
    //посчиатем какое количество имеется строк в массиве которые имеют длину не больше трех
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            count++;
        }
    }
    //Сгенерируем массив из полученного подсчета
    string[] finalArray = new string[count];
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            finalArray[k] = arr[i];
            k++;
        }
    }
    return finalArray;
}


//1. Сгенерируем массив из случайной цифры от 1 до 20
string[] array = new string[new Random().Next(1, 20)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(CutArray(array));