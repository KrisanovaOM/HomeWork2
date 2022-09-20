//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//метод определения дня недели
void GetDayWeek(int a)
{
  if (a == 1)
  {
    Console.WriteLine("Понедельник");
  }
   else if (a == 2)
  {
    Console.WriteLine("Вторник");
  }
   else if (a == 3)
  {
    Console.WriteLine("Среда");
  }
   else if (a == 4)
  {
    Console.WriteLine("Четверг");
  }
   else if (a == 5)
  {
    Console.WriteLine("Пятница");
  }
   else if (a == 6)
  {
    Console.WriteLine("Суббота");
  }
   else if (a == 7)
  {
    Console.WriteLine("Воскресенье");
  }
  else
  {
    Console.WriteLine("Ошибка: введите цифру в диапазоне от 1 до 7");
  }
}

//метод определения выходного дня
void Weekend(int b)
{
  if (b == 6 || b == 7)
  {
    Console.WriteLine("Выходной");
  }
}

//ввод числа
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetDayWeek(number);
Weekend(number);