using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3project
{
    internal class Class1
    {
        private String My_name;
        public void setvalue(String name1)
        {
            My_name = name1;
        }
        public string getvalue()
        {
            return My_name;
        }
        static void Main(string[] args)
        {


            Child2.Main(new String[] { });

            
        }

        internal class Dev : Class1
        {
            public Dev() : base("anchal", "aligarh") { }
            internal void print2()
            {
                Console.WriteLine($"the Derived user name is {name} and city is {city} and is age  {age} and ac num is {account}");
            }
        }
    }
}
