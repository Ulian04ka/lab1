using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_programm
{
    /// <summary>
    /// информация о студенте
    /// </summary>
    public class student
    {
        #region Fields 
        /// <summary>
        /// имя и фамилия студента
        /// </summary>
        private string name;
        /// <summary>
        /// группа
        /// </summary>
        private string group;
        /// <summary>
        /// факультет
        /// </summary>
        private string faculty;
        /// <summary>
        /// возраст студента
        /// </summary>
        private int age;
        /// <summary>
        /// номер студенческого
        /// </summary>
        private int number;
        #endregion
        #region Properties
        public int Age// повторить для каждого поля
        {
            get//ворачивает
            {
                return age;
            }
            set//меняет
            {
                if (value>6 && value<100)
                age = value;
                else
                {
                    age = 18;
                    Console.WriteLine("Попытка установления некорректного возраста {0}  для студента {1}", value, name);
                }
            }
        }
        #endregion
        #region Methods
        public virtual void print()
        {
            Console.WriteLine("Информация о студенте: ");
            Console.WriteLine("Фио: {0} ", name);
            Console.WriteLine("Факультет: {0} ", faculty);
            Console.WriteLine("Группа: {0} ", group);
            Console.WriteLine("Возраст: {0} ", age);
            Console.WriteLine("Студенческий: {0} ", number);
            Console.WriteLine();
        }
        #endregion
        // в конструкторе использовать свойства 
        #region Constractions 
        int NewNumber()
        {
            Random rnd = new Random();
            number = rnd.Next(100000, 999999);
            return number;
        }
        public student()
        {
            name = "moname";
            faculty = "math";
            number = NewNumber();
            group = "КБ";
            age = 18;
        }
        /// <summary>
        /// создание экземпляра класса студент
        /// </summary>
        /// <param name="fio">Фамилия и имя</param>
        /// <param name="gr">группа</param>
        /// <param name="fac">факультет</param>
        /// <param name="a">возраст</param>
        /// <param name="num">номер студенческого</param>
        public student(string fio, string gr, string fac, int a)
        {
            name = fio;
            group = gr;
            faculty = fac;
            age = a;
            number = NewNumber();
        }
        /// <summary>
        /// добавление студента по имени и группе
        /// </summary>
        /// <param name="fio">Фамия и имя</param>
        /// <param name="gr">группа</param>
        public student(string fio, string gr)
            : this(fio, gr, "math", 18) { }
        #endregion// 
        public static bool operator>(student s1, student s2)
        {
            return s1.age > s2.age;
        }
        public static bool operator<(student s1, student s2)
        {
            return s1.age < s2.age;
        }
    }
}
