using System;

class MyNewClass
{

    public static void MyTask34()
    {
        //Задайте массив, заполненный случайными положительными трехзначными числами. 
        //Напишите программу, которая покажет количество четных чисел в массиве
        System.Console.WriteLine("Задайте размер массива ");
        int Len = int.Parse(Console.ReadLine());
        int [] MyArr = new int [Len];
        int countNum = 0;
        for (int i = 0; i < Len; i++)
        {
            MyArr[i] = new Random().Next(100,1000);
            if (MyArr[i]%2 == 0)  countNum++;
        }

        System.Console.WriteLine(string.Join("  ", MyArr ));
        System.Console.WriteLine($"Количество четных элементов {countNum}" );
        
    }

    public static void MyTask36()
    {
        //Задайте одномерный массив, заполненный случайными числами. 
        //Найдите сумму элементов, стоящих на нечетных позициях
        System.Console.WriteLine("Задайте размер массива ");
        int Len = int.Parse(Console.ReadLine());
        int [] MyArr = new int [Len];
        int Summa = 0;
        for (int i = 0; i < Len; i++)
        {
            MyArr[i] = new Random().Next(-20,21);
            if (i%2 == 1)  Summa += MyArr[i];
        }

        System.Console.WriteLine(string.Join("  ", MyArr ));
        System.Console.WriteLine($"Сумма элементов на нечетных позициях {Summa}" );   
    }
    static void Main()
    {
       // MyTask34();
        MyTask36();
    }
    

}