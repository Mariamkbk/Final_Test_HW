// Итоговая проверочная работа
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе 
// Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.
// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, 
// как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FillArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        if (i < size - 1) arr[i] = $"\"{Console.ReadLine()}\", ";
        else arr[i] = $"\"{Console.ReadLine()}\"";
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}
string[] ArrayWithoutLongText(string[] arr)
{
    string[] ArrOnlySmall = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 7 && i < arr.Length - 1||arr[i].Length > 5 && i == arr.Length - 1) ArrOnlySmall[i] = "";
        else ArrOnlySmall[i] = arr[i];
    }
    return ArrOnlySmall;
}
try
{
    Console.WriteLine("Введите числовое значение размера массива");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] array = FillArray(length);
    Console.Write("Задан массив строк: ");
    PrintArray(array);
    string[] ArrShortWords = ArrayWithoutLongText(array);
    Console.Write("Строки размером 3 символа и менее: ");
    PrintArray(ArrShortWords);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
