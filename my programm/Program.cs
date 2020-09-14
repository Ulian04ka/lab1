using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace my_programm
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.print();
            student Ivanov = new student("Иванов Иван", "КБ");
            Ivanov.print();
            student Petrov = new student("Петров Иван", "КБ", "math", 19);
            Petrov.print();
            Petrov.Age = 13;
            Petrov.print();
            if (Ivanov > Petrov) Console.WriteLine("Иванов старше петрова");
            if (Ivanov < Petrov) Console.WriteLine("Иванов младше петрова");
            Starosta st = new Starosta();
            st.Age = 15;
            st.print();
            Console.ReadKey();
        }
    }
}