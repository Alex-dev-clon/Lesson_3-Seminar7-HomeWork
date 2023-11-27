// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
int ReadNumber(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Showintegers (int firstNum, int secondNum){
    if (firstNum <= 0) firstNum = 1;
    if (firstNum > secondNum) {
        Console.WriteLine("\nEnd");
        return;
    }
    Console.Write(firstNum + " ");
    Showintegers (firstNum + 1, secondNum);
}

int m = ReadNumber("Enter the first number: ");
int n = ReadNumber("Enter the second number: ");
Console.Write("Result is: ");
Showintegers(m, n);