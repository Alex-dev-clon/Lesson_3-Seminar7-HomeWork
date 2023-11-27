// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
int ReadNumber(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] CreateArray (int size){
    int [] array = new int [size];
    for (int i = 0; i < size; i++){
    array[i] = new Random().Next(0, 100);
    }
    return array;
}

void ReverseArray (int [] array, int mark){
    if (mark < array.Length - 1) ReverseArray (array, mark + 1);
    Console.Write(array[mark] + " ");
    return;
}

int [] array = CreateArray(ReadNumber("Enter size of array: "));
Console.WriteLine($"Source array: {string.Join(" ", array)}");
Console.Write("New array: ");
int mark = 0;
ReverseArray (array, mark);