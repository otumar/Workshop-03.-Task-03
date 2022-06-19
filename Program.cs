// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int number = Prompt("Введите число: ");
int count = 0;
while (count < number)
{
count++;
System.Console.WriteLine(count*count*count);
}