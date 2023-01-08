//тело программы

int start_size = InputInt();
string[] array = new string[start_size];
array = InputString(array);
PrintArrayString(FiltersForArray(array));


//методы

int InputInt()
{
    Console.WriteLine("Введите кол-во элементов в массиве");

    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if(isParse)
    {
        return number;
    }
    else
    {
        throw new ArgumentException("Вы ввели некорректное значение!!!");
    }
}

string[] InputString(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите строку: ");
        array[i] = Console.ReadLine();
    }

    return array;
}

void PrintArrayString(string[] array)
{
    Console.WriteLine("------------------");
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine("------------------");
}

string[] FiltersForArray(string[] array)
{
    int result_size = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            result_size++;
        }
    }

    string[] result_array = new string[result_size];
    int j = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            result_array[j] = array[i];
            j++;
        }
    }

    return result_array;
}