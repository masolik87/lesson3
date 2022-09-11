/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

/*
{ 
   int index = 1;
   while(index <= number)
   {
    Console.Write(index * index * index);
    Console.Write(", ");
    index++;
   }
}   
Console.WriteLine();
*/

for (int i = 1; i <= number; i++)
{
    Console.Write(i * i * i);
    Console.Write(", ");
}
Console.WriteLine();