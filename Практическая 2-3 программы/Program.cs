using System;
using System.Net;

string plays;
while (true)
{
    Console.Clear();
    Console.WriteLine("1. \"Угадай число\"\n" + "2. Таблица умножения\n" + "3. Вывод делителей числа\n");
    string plays1 = Console.ReadLine();
    int a = Convert.ToInt32(plays1);
    double answer;
    if (a == 1)
        answer = Convert.ToDouble(plays1);
    if (a == 2)
        answer = Convert.ToDouble(plays1);
    if (a == 3)
        answer = Convert.ToDouble(plays1);
   

       
        {   if (a == 1)
        {
            Console.WriteLine("1. Игра угадай число");

            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            Random random = new Random();
            int k = random.Next(x, y);
            int count = 0;
            string str;
            Console.WriteLine("Угадайте число в интервале от {0} до {1}\n", x, y);
            do
            {
                Console.Write("Ваш вариант: ");
                str = Console.ReadLine();

                if (int.Parse(str) < k)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(str) > k)
                    Console.WriteLine("Задуманное число меньше");

                count++;
            }
            while (int.Parse(str) != k);

            Console.WriteLine("Вы угадали с {0} попытки", count);
            Console.ReadLine();
        }
    }
    


    {      if (a == 2)
        {


            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + "   |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
    {       if (a == 3)
        {



            Console.WriteLine("3. Вывод делителей числа");

            Console.Write("Введите число ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                if (num % i == 0)
                    Console.WriteLine("Число {0} делится без остатка на {1}", num, i);

            Console.ReadKey();
        }
    }
}


   















