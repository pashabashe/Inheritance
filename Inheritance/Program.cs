using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //мы создаем объект класса Employee следующим образом:

            Employee tom = new Employee("Tom", "Microsoft");//точка останова 

            //Какие конструкторы и в каком порядке в данном случае будет выполняться...
        }
        class Person
        {
            string name;
            int age;

            public Person()
            {
            }
            public Person(string name) : this(name, 18)
            {
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        class Employee : Person
        {
            string company;

            public Employee()
            {
            }
            public Employee(string name, int age, string company) : base(name, age)
            {
                this.company = company;
            }
            public Employee(string name, string company) : base(name)
            {
                this.company = company;
            }
        }
    }
}//Порядок выполнения конструкторов:

// 1. System.Object.Object()

// 2. Person(string name, int age)

// 3. Person(string name)

// 4. Employee(string name, string company)    