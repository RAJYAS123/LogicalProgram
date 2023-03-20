using array;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace array_with_user_input
{
    class Programs
    {

        //public class BaseClass
        //{
        //    public virtual void show()   //Method overriding 
        //    {
        //        Console.WriteLine("this is base class's method");
        //    }
        //}
        //public class ChildClass:BaseClass
        //{
        //    public override void show()
        //    {
        //        Console.WriteLine("this is base class's method");
        //    }
        //}

        private string studentname;
        private int studentage;
        public string Name
        {
            get
            {
                return studentname;
            }
            set
            {
                studentname = value;
            }
        }

        public int Age
        {
            get
            {
                return studentage;
            }
            set
            {
                studentage = value;
            }
        }
        static void Main(string[] args)
        {
            Programs obj = new Programs();
            obj.Name = "yash";
            obj.Age = 20;
            Console.WriteLine("Name :"+obj.Name);       
            Console.WriteLine("Age :"+obj.Age);       
            //BaseClass baseClass = new ChildClass();
            //baseClass.show();
            //Console.ReadLine();
            //int a = 10;     //Swapping of two number using 3 veriable
            //int b = 20;
            //int temp;
            //Console.WriteLine("before swapping of values a={0},b={1}",a,b);
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("After swapping of values a={0},b={1}", a, b);
            //Console.ReadLine();

            int a = 50;     //Swapping of two number without 3 veriable
            int b = 100;          
            Console.WriteLine("before swapping of values a={0},b={1}", a, b);
            a = a + b;
            b = a - b; 
            a = a - b;
            Console.WriteLine("After swapping of values a={0},b={1}", a, b);
            Console.ReadLine();
            //3.first latter of string is captail
            //string words = Console.ReadLine();
            //char delimiter = ' ';
            //string[] substrings = words.Split(delimiter);
            //foreach (var substring in substrings)
            //{
            //    if (substring != "")
            //    {
            //        string word = substring;
            //        string firstlatter = word[0].ToString();
            //        firstlatter = firstlatter.ToUpper();
            //        word = word.Substring(1, word.Length - 1);
            //        word = firstlatter + word;
            //        Console.Write(word + " ");
            //    }
            //}
            //Console.ReadLine();



            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("fibonacci series ");
            //int a = 0;
            //int b = 1;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //for (int i = 0; i <= n; i++)
            //{
            //    int c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //}
            //Console.ReadLine();


            // 1. reverse string 
            //string input = Console.ReadLine();
            //string rev = "";
            //int len = input.Length - 1;
            //while(len >= 0)
            //{
            //    rev = rev + input[len];
            //    len--;
            //}
            //Console.Write(rev);
            //Console.ReadLine();


            //5. Delete Duplicate item from an array using linq
            //int[] arryy = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            //int[] array = arryy.Distinct().ToArray();
            //Array.ForEach(array, x => Console.WriteLine(x));
            //Console.ReadLine();

            ////5. Delete Duplicate item from an array for string
            //string[] yash = { "vipul", "vipul", "yash", "yash", "vijay", "vijay" };
            //string[] tak = yash.Distinct().ToArray();
            //Array.ForEach(tak, x => Console.WriteLine(x));
            //Console.ReadLine();


            //remove duplicate item from array
            //int[] arr = { 1, 2, 4, 1, 6, 2, 4, 7 };
            //int[] temp = new int[arr.Length];
            //int j = 0;
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(a + " ");
            //}

            //Console.WriteLine("\n -------------------------");
            //for (var i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] != arr[i + 1])
            //    {
            //        temp[j++] = arr[i];
            //    }

            //}
            //temp[j++] = arr[arr.Length - 1];
            //for (var i = 0; i < j; i++)
            //{
            //    Console.Write(temp[i] + " ");
            //}


            //int i = 0;
            //for (int i = 0; i < 1; i--)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadLine();
            //}


            //Serialization Program In C# To Store Object Data In Any Type Of File Like txt,jpg,png,exe,docx,pdf

            //string path = @"E:\YASH\Sample.txt";
            //Employee employee = new Employee(123, "YAsh");
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //binaryFormatter.Serialize(fs, employee);
            //fs.Close();
            //Console.WriteLine("File Created Successfully" + path);
            //Console.ReadLine();

            ////De-Serialization Program In C# To Store Object Data In Any Type Of File Like txt,jpg,png,exe,docx,pdf

            //string Path = @"E:\YASH\Sample.txt";
            //FileStream fileStream = new FileStream(Path, FileMode.OpenOrCreate);
            //BinaryFormatter bf = new BinaryFormatter();
            //Employee emp = (Employee)bf.Deserialize(fileStream);
            //Console.WriteLine("EMployee ID " + emp.Id);
            //Console.WriteLine("Employee Name "+ emp.Name);
            //fileStream.Close();
            //Console.ReadLine();


            //Test test = new Test();
            //test.add();
            //Console.ReadLine();
            //int a = 5;
            //for (int i = 5; i >= 1; i--)    //for number pattern 
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }

            //    Console.WriteLine();
            //}
            //int n = 4;
            //int num = 1;
            //for (int i=1; i<=n; i++)       //for number pattern
            //{
            //    for (int j=1; j<=i; j++)
            //    {
            //        Console.Write(num +" ");
            //        num++;

            //    }

            //    Console.WriteLine();
            //    Console.ReadLine();


            //}


            //for (int i = 1; i <= 5; i++)       //for star pattern
            //{
            //    for (int j =i; j <=5; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();



            //}
            //Console.ReadLine();



            //Employee employee = new Employee();
            //employee.id = 1;
            //employee.name = "yash";
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("D:\\ex.txt", FileMode.Create, FileAccess.Write);
            //formatter.Serialize(stream, employee);
            //stream.Close();

            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Hello Yash");
            }
            Console.ReadLine();


            int c = 10;
            int d = 100;
            Console.WriteLine("Before Swapping the number:c={0},d={1}",c,d);
            c = c + d;
            d = c - d;
            c = c - d;
            Console.WriteLine("Before Swapping the number:c={0},d={1}", c, d);
            Console.ReadLine();


            int x = 10;
            int y = 100;
            int temp;
            Console.WriteLine("Before Swapping the number:c={0},d={1}", x, y);

        }

        [Serializable]
        public class Employee
        {
            public int id;
            public string name;
        }
    }

    //public interface ITest
    //{
    //    void add();
    //}

    //public class Test : ITest
    //{
    //    public void add()
    //    {
    //        int a = 10;
    //        int b = 20;
    //        int result = a + b;
    //        Console.WriteLine(result);
    //        Console.ReadLine()
    //    }
    //}
}
