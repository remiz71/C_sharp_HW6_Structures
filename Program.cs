using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_HW6_Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Создание и ввод данных
            string[] subject = null; // subject array
            int[][] marks = null; // marks array
            //1.1 Ввод данных
            Console.WriteLine("Интерфейс ввода данных в ведомость".);
            Console.Write(" Введите кол-во предметов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            subject = new string[n]; // выделение памяти под массив
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите предмет ({i + 1}/{n}) : ");
                subject[i] = Console.ReadLine(); // Ввод предмета
            }

            // Ввод оценок
            marks = new int[n][]; //выделение памяти под строки

            // Ввод оценок по каждому предмету
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите количество оценок по предмету {subject[i]}: ");
                int m = Convert.ToInt32(Console.ReadLine());
                marks[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введите оценку ({j + 1}/{m}): ");
                    marks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            //2.Красивый вывод оценок
            Console.WriteLine("\tВЕДОМОСТЬ СТУДЕНТА");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Предмет\t|Оценки");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write($"{subject[i]}\t| ");
                foreach (int mark in marks[i])
                    Console.Write($"{mark} ");
                Console.WriteLine();                
            }
                Console.WriteLine("----------------------------------------");
            //3. Посчитать среднее значение
            double total_sum = 0;
            for (int i = 0; i < subject.Length; i++)
            {
                double av = marks[i].Average();
                total_sum += av;
                Console.WriteLine($"Средний балл по {subject[i]}: {marks[i].Average()}");
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Общий средний балл: {total_sum / subject.Length}");
            Console.WriteLine("--------------------------------------");
            // 4. Аттестован ли студент или нет?
            Console.Write("Атесстация студента: ");
            int marksQuantity = 0;
            for (int i = 0; i < subject.Length; i++)
            {
                foreach (int mark in marks[i])
                    marksQuantity++;
            }
            if(total_sum / subject.Length > 2.5 && marksQuantity > 2)
                Console.WriteLine("Студент аттестован!");
            else Console.WriteLine("Студент не аттестован");
            Console.WriteLine("--------------------------------------");
            //5.Реализация поиска максимальной и минимальной оценки
            double MaxMark = 0;
            double MinMark = 10;
            for (int i = 0; i < subject.Length; i++)
            {
                foreach (int mark in marks[i])
                {
                    if (mark > MaxMark) MaxMark = mark;
                    if (mark < MinMark) MinMark = mark;
                }
                    Console.WriteLine($"Максимальная оценка по {subject[i]} -\t{MaxMark}");
                    Console.WriteLine($"Минимальная оценка по {subject[i]} -\t{MinMark}");
                    MaxMark = 0;
                    MinMark = 12;
                
            }
            Console.WriteLine("--------------------------------------");


        }
    }
}
