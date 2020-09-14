using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_programm
{
    class Starosta:student
    {
        string email;
        int phone;
        public Starosta() { }
        public Starosta(string fio, string gr, string fac, int a, string ema, int ph)
            :base(fio, gr, fac, a)
        {
            email = ema;
            phone = ph;
        }
        public override void print()
        {
            base.print();
            Console.WriteLine("Email: {0} ", email);
            Console.WriteLine("phone: {0} ", phone);
        }
        //public void Print()
        //{
        //    base.print();
        //    Console.WriteLine("Email: {0} ", email);
        //    Console.WriteLine("phone: {0} ", phone);
        //}
    }
}
