using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class7
    {
        private int sallery;
        private int ac_num;

        private Class7(int sallery, int ac_num)
        {
            this.sallery = sallery;
            this.ac_num = ac_num;
        }

        public void Setvalue(int sallery, int ac_num)
        {
            this.sallery = sallery;
            this.ac_num = ac_num;
        }
        public void Getvalue()
        {

            Console.WriteLine($" Sallery is {aellery} and account number is {ac_num}");

        }
        internal static void Main(string[] args)
        {

            Class7 c7 = new Class7(1200, 12345);
            c7.Getvalue();
            c7.Setvalue(1001, 55554);
            c7.Getvalue();
            Console.ReadLine();
        }
    }
}
