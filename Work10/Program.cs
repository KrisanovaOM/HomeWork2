//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//функция определения второй цифры трехзначного числа
int InCenter(int a)
{
  int result = ((a / 10) % 10);
  return result;
}

//функция проверки числа на трехзначность и вывод второй цифры
void GetTwoDigit(int b)
{
  int amout = b.ToString().Length;
  if (amout < 3 || amout > 3)
  {
    Console.WriteLine("Вы ввели не трехзначное число");
  }
  else
  {
    Console.WriteLine(InCenter(b));
  }

}

//ввод трехзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetTwoDigit(number);

