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
       public static void MyTask37()
     {
        // Найдите произведение пар чисел в одномерном массиве.
        // Парой считаем первый и последний элемент, второй и предпоследний
        // и т.д. Результат запишите в новом массиве
        
        System.Console.WriteLine("Задайте размер массива ");
        int Len = int.Parse(Console.ReadLine());
        int [] MyArr = new int [Len];
        for (int i=0; i< MyArr.Length; i++)
        {
            MyArr[i] = new Random().Next(-9,10);
        }

        Console.WriteLine(String.Join(" ", MyArr));
       
        int Len2;
        if (MyArr.Length % 2 == 0) Len2 = MyArr.Length/2;
        else Len2=MyArr.Length/2+1;
        
        int [] NewArr =  new int[Len2];
        
        for (int i=0; i < MyArr.Length-i; i++)
        {
            if (i != MyArr.Length-1-i )  NewArr[i] = MyArr[i]*MyArr[MyArr.Length-1-i]; 
            else NewArr[i] = MyArr[i];
        } 
        Console.WriteLine(String.Join(" ", NewArr));

     }
    public static void MyTask38()
    {
        // Задайте массив вещественных чисел. Найдите разницу между 
        // максимальным и минимальным элементами массива

        System.Console.WriteLine("Задайте размер массива ");
        int Len = int.Parse(Console.ReadLine());
        double [] MyArr = new double [Len];
        //заполняем массив случайными вещественными числами
        for (int i=0; i< MyArr.Length; i++)
        {
            MyArr[i] = Math.Round(new Random().NextDouble()*10, 2);
        }
        
        //вывод массива
        System.Console.WriteLine(string.Join("  ", MyArr));
        
        //поиск минимального и максимального элемента
        double max=MyArr[0], min=MyArr[0];
        for (int i=0; i< MyArr.Length; i++)
        {
            if (MyArr[i] > max) max = MyArr[i] ;
            
            if (MyArr[i] < min) min = MyArr[i];      
        }

        System.Console.WriteLine($"разница между мин. и макс. элементами  = {Math.Round(max - min, 2)}");

        }

    static void Main()
    {
       // MyTask34();
       // MyTask36();
       // MyTask37();
        MyTask38();

    }
    

}