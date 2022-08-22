// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("*Вас приветствует искусственный интеллект Core 2.0*");
Console.WriteLine("Сейчас я продемонстрирую Вам магию!");

Console.Write("Пожалуйста, введите первое целое число, для того, что бы магия состоялась! ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (num1 > count) { num1 = num1 / 10; count++;}
Console.WriteLine($"Магия! количество цифр в числе {count}");
Console.WriteLine("Буду рад пообщаться снова! =) ");
