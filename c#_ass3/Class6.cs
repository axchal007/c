using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class6
    {
        public int age;
        public String name;
        public Class6(int age, String name)
        {
            this.age = age;
            this.name = name;
        }
        public void getempinfo()
        {
            Console.WriteLine($"the employee name is {name} and age is {age}");
        }
    }

    internal class Child2 : Class6
    {
        public static void Main(string[] args)
        {
            Child2 c2 = new Child2();
            c2.getempinfo();
        }
        public Child2() : base(21, "anchal")
        {
            Console.ReadLine();
        }
    }
}
