/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
Пример:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
void NewRandomArray(int[] number)
{
    int size = number.Length;
    int index = 0;
    while (index < size)
    {
        number[index] = new Random().Next(0,10000);
        index++;
    }
}
void PrintArray(int[] PrintArray)
{
    int size = PrintArray.Length;
    int index = 0;
    while (index < size)
    {
        Console.WriteLine(PrintArray[index]);
        index++;
    }
}

int[] array = new int[15];

NewRandomArray(array);
PrintArray(array);
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number < -100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int stage1 = number / 100;
    int index1 = 0;
    while(stage1>1)
    {
        index++;
        stage1 = stage1 /10;
    }
    int stage2 = 0;
    int index2 = 0;
    if (index1>1)
    {
        stage2 = number / 10 % 10;
        
    }
}



