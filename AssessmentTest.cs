using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace array
{
    public class AssessmentTest
    { 

        public static async void task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 1 starting");
                Thread.Sleep(2000);
                Console.WriteLine("task 1 completed");
            });
           
        }   
         

        public static async void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 2 starting");
                Thread.Sleep(4000);
                Console.WriteLine("task 2 completed");

            });
        }

        public static async void task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 3 starting");
                Thread.Sleep(5000);
                Console.WriteLine("task 3 completed");

            });
        }

        public static async void task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 4 starting");
                Thread.Sleep(1000);
                Console.WriteLine("task 4 completed");
            });
            Console.WriteLine("hello");
           
        }

        public int x;
        public double y;
        public int add(int a, int b)
        {
            x = a + b;
            return x;
        }
        public int add(double c, double d)
        {
            y = c + d;
            return (int)y;
        }
        public AssessmentTest()
        {
            this.x = 0;
            this.y = 0;
        }


        class A
        {
            public int i;
            public void display()
            {
                Console.WriteLine("my name is yash from first class");
            }
        }

        class B : A
        {
            public int j;
            public void display()
            {
                Console.WriteLine("my name is yash from second class");
            }
        }

        public static void Main(string[] args)
        {
            //AssessmentTest obj = new AssessmentTest();
            //int a = 4;
            //double b = 3.5;
            //obj.add(a, a);
            //obj.add(b, b);
            //Console.WriteLine(obj.x + " " + obj.y);
            //B obj = new B();
            //obj.i = 1;
            //obj.j = 2;
            //obj.display();
            ////Console.ReadLine();
            //StringBuilder stringBuilder = new StringBuilder("Hello world");
            ////stringBuilder.Insert(5,"baby");
            //stringBuilder.Remove(2,5);
            //Console.WriteLine(stringBuilder);
            //student objstd = new student();
            //objstd.Stdid = 1;
            //objstd.Name = "yash";
            //objstd.Address = "Khalilabad";
            //Console.WriteLine(objstd.Name +" "+ objstd.Stdid +" "+ objstd.Address);
            //A obj = new A();
            //obj.display();
            //string str = "  Hello  ";
            //string strtrim = str.Trim();
            //Console.WriteLine(strtrim);
            task1();
            task2();
            task3();
            task4();
            AssessmentTest assessmentTest = new AssessmentTest();

            for(int i=0;i<=10;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        public class student
        {
            private int _stdid;
            private string _name;
            private string _address;

            public int Stdid
            {
                set
                {
                    this._stdid = value;
                }
                get
                {
                    return this._stdid;
                }
            }

            public string Address
            {
                set
                {
                    this._address = value;
                }
                get
                {
                    return this._address;
                }
            }

            public string Name
            {
                set
                {
                    this._name = value;
                }
                get
                {
                    return this._name;
                }
            }
        }

    }
}
