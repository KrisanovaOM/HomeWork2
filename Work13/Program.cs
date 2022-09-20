//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//функция проверки числа на разрядность больше 3 и вывод третьей цифры
void GetThreeDigit(int a)
{
string amout = a.ToString();
int count = a.ToString().Length;

if (count < 3)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine(amout[2]);
 }

}

//ввод числа
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetThreeDigit(number);


