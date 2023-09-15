using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class9
    {
        protected int age;
        public String name;
        public Class9(int age, String name)
        {
            this.age = age;
            this.name = name;
        }
        protected void getempinfo()
        {
            Console.WriteLine($"the employee name is {name} and age is {age}");
        }
    }
    internal class Dev1 : Class9
    {
        internal Dev1() : base(21, "anchal")
        { }
        public void Print3()
        {
            Console.WriteLine("it is print method of Dev class");
            getempinfo();
        }
    }
}
