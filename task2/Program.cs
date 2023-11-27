// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// Пример m = 2, n = 3 -> A(m,n) = 29
// НЕВЕРНЫЙ ПРИМЕР A(2,3) = 9 ПО ТАБЛИЦЕ ЗНАЧЕНИЙ АККЕРМАНА
int ReadNumber(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkermann(int n, int m)
{
  if (n == 0) return m + 1;
  else if (m == 0) return Akkermann(n - 1, 1);
  else return Akkermann(n - 1, Akkermann(n, m - 1));
}

int m = ReadNumber("Enter m number: ");
int n = ReadNumber("Enter n number: ");
int result = Akkermann (m, n);
Console.WriteLine("Result: " + result);