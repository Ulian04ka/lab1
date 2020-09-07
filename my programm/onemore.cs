///*Даны две последовательности, требуется найти и вывести их наибольшую общую
//подпоследовательность.
//алгоритм Нидлмана—Вунша*/
//using System;
//using System.Collections.Generic;

//namespace programm
//{
//    class Program
//    {
//        static void Sequence(int[,] order, int[] First, int[] Second)
//        {
//            Stack<int> answer = new Stack<int>();// Заводим стек для запоминания последовательности
//            int i = First.Length - 1, j = Second.Length - 1;
//            while (i > 0 && j > 0)
//            {
//                if (First[i] == Second[j])// если в этом месте было совершено увеличение (т.е. +1; символы одинаковы)
//                {
//                    answer.Push(First[i]);// кидаем в стек и идем на следущий левый верхний по диоганали
//                    i--; j--;
//                }
//                else
//                {
//                    if (order[i - 1, j] > order[i, j - 1]) //  иначе двигаемся в сторону наибольшего элемента (или на лево, если элементы равны)
//                        i--;
//                    else
//                        j--;
//                }
//            }
//            Console.WriteLine();
//            foreach (int x in answer)//  выводим ответ
//                Console.Write("{0} ", x);
//        }
//        static int Order(int[,] order, int[] First, int[] Second, int i, int j)
//        {
//            if (order[i, j] != -1)// если число уже вычисленно
//                return order[i, j];
//            if (i == 0 || j == 0)// уголок из 0
//                order[i, j] = 0;
//            else
//            {
//                if (First[i] == Second[j])// если элементы равны, то берем верхний левый элемент по диагонали и прибавляем к нему 1
//                    order[i, j] = (Order(order, First, Second, i - 1, j - 1) + 1);
//                else// иначе берем максимум из верхнего и левого
//                    order[i, j] = System.Math.Max(Order(order, First, Second, i, j - 1), Order(order, First, Second, i - 1, j));
//            }
//            return order[i, j];
//        }
//        static void Main(string[] args)
//        {
//            string[] N;
//            int[] First, Second;
//            int n = int.Parse(Console.ReadLine());
//            N = Console.ReadLine().Split();// кол-во элементов в первой последовательности
//            First = new int[n + 1];
//            for (int i = 1; i < n + 1; i++)
//                First[i] = int.Parse(N[i - 1]);// первая последовательность

//            n = int.Parse(Console.ReadLine());
//            N = Console.ReadLine().Split();// кол-во элементов во второй последовательности
//            Second = new int[n + 1];
//            for (int i = 1; i < n + 1; i++)
//                Second[i] = int.Parse(N[i - 1]);// вторая последовательность

//            int[,] order = new int[First.Length, Second.Length];
//            for (int i = 1; i < First.Length; i++)
//                for (int j = 1; j < Second.Length; j++)
//                    order[i, j] = -1;//  матрица для вычислений

//            order[First.Length - 1, Second.Length - 1] = Order(order, First, Second, First.Length - 1, Second.Length - 1);// вычисление матрицы(этот элемент равен длинне последовательности)
//            Sequence(order, First, Second);// выводим саму последовательность
//            Console.ReadKey();
//        }
//    }
//}