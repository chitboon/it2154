using System;
using System.Collections.Generic;

namespace Q1
{
    class Program
    {
        struct Student {
            public Student(string name, int age, double height) {
                this.name = name;
                this.age = age;
                this.height = height;
            }
            public string name;
            public int age;
            public double height;
        }
        
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.name = "John";
            stud.age = 18;
            stud.height = 170.6;

            Console.WriteLine("{0}, {1}, {2}", stud.name, stud.age, stud.height);

            stud = new Student("Mary", 81, 155.5);
         

            Console.WriteLine("{0}, {1}, {2}", stud.name, stud.age, stud.height);


            doCalculation calc = new doCalculation(AddNumber);
            doCalculation calc1 = AddNumber;
            doCalculation calc3 = (int n1, int n2) => n1+n2;

            int i = calc.Invoke(2,3);
            Console.WriteLine(i);
            i = calc(2,3);
            Console.WriteLine(i);


            GenericExample();

        }

        public static int AddNumber(int n1, int n2) {
            return n1+n2;
        }

        public static int MultiplyNumber(int n1, int n2) {
            return n1*n2;
        }

        public delegate int doCalculation(int n1, int n2);

        dynamic i = 5;

        public static void GenericExample() {
            List<string> list = new List<string>();
            list.Add("John");
            list.Add("Mary");
            foreach (var name in list) {
                Console.WriteLine(name);
            }
        }
    }
}
