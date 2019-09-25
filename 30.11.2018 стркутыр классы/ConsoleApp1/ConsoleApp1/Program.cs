
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int @int;

            Dimension dimension = new Dimension();

            dimension.Print();

            Dimension dim1 = new Dimension(12.6, 56.8);

            dim1.Print();

            DateTime dateTime = DateTime.Now;

            DateTime date = new DateTime(2000, 9, 12); // 9

            Console.WriteLine(date.DayOfWeek);

            TimeSpan timeSpan = DateTime.Now - date;

            Console.WriteLine(timeSpan.TotalDays); // 11:18 -> 6652,47051378314

            Console.WriteLine(DateTime.Today.Year - date.Year);
            Console.WriteLine((int)(timeSpan.TotalDays/365.25));


            Student student = new Student(new DateTime(1998, 5, 23));
            student.Show();























            //Random random = new Random();
            //int[,] arr2 = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arr2[i, j] = random.Next(-10, 10);
            //        Console.Write(arr2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //int min = arr2[0, 0], minR = 0, minC = 0, max = arr2[0, 0], maxR = 0, maxC = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (arr2[i, j] > max)
            //        {
            //            max = arr2[i, j];
            //            maxR = i;
            //            maxC = j;
            //        }
            //        if (arr2[i, j] < min)
            //        {
            //            min = arr2[i, j];
            //            minR = i;
            //            minC = j;
            //        }
            //    }
            //}
            ////Array
            //Console.WriteLine($"Min: {min} --- {minR} --- {minC}");
            //Console.WriteLine($"Max: {max} --- {maxR} --- {maxC}");
            //int sum = 0;
            ////if (minR < maxR)
            ////{
            ////    for (int i = 0; i < 5; i++)
            ////    {
            ////        for (int j = 0; j < 5; j++)
            ////        {
            ////            if (i == minR && j > minC || i > minR && i < maxR || i == maxR && j < maxC)
            ////            {
            ////                Console.Write(arr2[i, j] + "\t");
            ////                sum += arr2[i, j];
            ////            }
            ////        }
            ////    }
            ////}
            ////else
            ////{
            ////    for (int i = 4; i >= 0; i--)
            ////    {
            ////        for (int j = 4; j >= 0; j--)
            ////        {
            ////            if (i == minR && j < minC || i > minR && i < maxR || i == maxR && j > maxC)
            ////            {
            ////                Console.Write(arr2[i, j] + "\t");
            ////                sum += arr2[i, j];
            ////            }
            ////        }
            ////    }
            ////}

            //int start = (minR * 5) + minC;
            //int finish = (maxR * 5) + maxC;
            ////Console.WriteLine($"Start: {start} Finish: {finish}");

            //int index = 0;
            //if (start < finish)
            //{
            //    foreach (int item in arr2)
            //    {
            //        if (index > start && index < finish)
            //        {
            //            Console.Write(item + "\t");
            //            sum += item;
            //        }
            //        index++;
            //    }
            //}
            //else
            //{
            //    foreach (int item in arr2)
            //    {
            //        if (index > finish && index < start)
            //        {
            //            Console.Write(item + "\t");
            //            sum += item;
            //        }
            //        index++;
            //    }
            //}
            //Console.WriteLine($"Sum: {sum}");

            Console.ReadKey();
        }
    }
}