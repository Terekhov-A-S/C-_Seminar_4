// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("*Вас приветствует искусственный интеллект Core 2.0*");
Console.WriteLine("Сейчас я продемонстрирую Вам магию! Я придумаю массив цифр и покажу Вам их:");
int[] array = new int[8];
Random num = new Random();
for (int count = 0; count < 8; count++)
{
    array[count] = num.Next(0, 999999999);
    Console.WriteLine($"_-* {array[count]} *-_");
}
Console.WriteLine("Буду рад пообщаться снова! =) ");
Console.WriteLine();
