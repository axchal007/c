using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3project
{
    internal class Class5
    {
        protected internal String name;
        protected internal String city;
        protected int age = 21;
        protected int account = 987787;

        protected Class5(String name, String city)
        {
            this.name = name;
            this.city = city;
        }
        protected internal void GetUserInfo()
        {
            Console.WriteLine($"Student name is{name} and city is {city}");

        }
    }
}
