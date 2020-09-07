///*В матрице, состоящей из нулей и единиц, найдите квадрат(квадратная подматрица) 
// * наибольшего размера, состоящая только из нулей.*/
//using System;
//using System.IO;

//namespace programm
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int size = 0, n = 0, m = 0;
//            string[] s = Console.ReadLine().Split();
//            n = int.Parse(s[0]); m = int.Parse(s[1]);// размерность
//            int[,] matriza = new int[n, m];
//            for (int i = 0; i < n; i++)
//            {
//                s = Console.ReadLine().Split();
//                for (int j = 0; j < m; j++)
//                    matriza[i, j] = int.Parse(s[j]) == 0 ? 1 : 0;//заполняем матрицу
//            }
//            for (int i = 0; i < n; ++i)
//            {
//                for (int j = 0; j < m; ++j)
//                {
//                    if (i * j == 0) continue;
//                    if (matriza[i, j] == 1)//оставляем "рамку" от которой все расчитываем
//                        matriza[i, j] = System.Math.Min(System.Math.Min(matriza[i, j - 1], matriza[i - 1, j]), matriza[i - 1, j - 1]) + 1;
//                    // минимум из левого, верхнего и левого диагонального
//                    if (matriza[i, j] > size)
//                        size = matriza[i, j];// находим максимльный размер
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine(size);
//            Console.ReadKey();
//        }
//    }
//}
