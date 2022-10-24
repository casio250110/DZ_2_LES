// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
if (number > 99){
    int a = int.Parse(Convert.ToString(number)[2].ToString());
    Console.WriteLine(a);
}
else Console.WriteLine("Третьей цифры нет");