using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    public class Priamid
    {
        int raj;
        int yok;
        public Priamid(int raja,int yoka)           //parametrized constructor
        {
            this.raj = raja;
            this.yok = yoka;
        }
        public class parent
        {
            public virtual void show()
            {
                Console.WriteLine("this is parent method");
            }
        }

        public class child :parent
        {
            public override void show()
            {
                Console.WriteLine("this is child method");
            }
        }

        public static class yash
        {
            public static int a;
            public static void show3()
            {
                Console.WriteLine("hello baby hou are you");
            }
            
        }

        public abstract class mobile
        {
           public virtual void Yes()
            {
                Console.WriteLine("abstruct class parent  method");
            }
        }

        public  class noida: mobile
        {
            public override void Yes()
            {
                Console.WriteLine("abstruct class child method");
            }
        }

        public interface customer
        {
            void kk();
        }

        public class todo :customer
        {
            private string employeename;
            private string Employeename
            {
                get
                {
                    return employeename;
                }
                set
                {
                    employeename = value;
                }
            }

            public void kk()
            {
                Console.WriteLine("here is interface method");
            }
        }

        static void Main(string[] args)
        {
            //yash.show3();
            //noida noida = new noida();
            //noida.Yes();
            //child parent = new child();
            //parent.show();
            //int a = 20;
            //int b = 30;
            //Console.WriteLine("Before Swapping Of Number:a={0},b={1}",a,b);
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("After Swapping Of Number:a={0},b={1}", a, b);
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i <=9; i++)
            //{
            //    for (int j = i; j <= 9; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}
            //string[] cars = new string[4] { "yash", "raj", "toy", "kk" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}
            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> obj = new List<string>();
            //obj.Add("yash");
            //obj.Add("raj");
            //foreach (var item in obj)
            //{
            //    Console.WriteLine(item);
            //}

            //int no = 4;
            //int fact = 1;
            //for (int i = 1; i <=no; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine(fact);
            //var jj = Tuple.Create(1,"yash");
            //Console.WriteLine(jj);
            //int[] arr = new int[3] { 1, 2, 3};

            //int boxing = 10;
            //object obj = boxing;

            //StringBuilder stringBuilder = new StringBuilder("hello world!!", 50);
            //stringBuilder.Remove(6,5);
            //Console.WriteLine(stringBuilder);




            //string input = Console.ReadLine();    //reverse of any strings
            //string rev = "";
            //int len = input.Length - 1;
            //while (len >= 0)
            //{
            //    rev = rev + input[len];
            //    len--;
            //}
            //Console.Write(rev);

            //string[] cars = new string[4] { "yash", "raj", "toy", "kk" };
            //var dd = from a in cars select a;
            //foreach (var item in dd)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine(per.b);
            int take = 12345;
            int remain;
            int result = 0;
            while (take != 0)
            {
                remain = take % 10;
                result = result * 10 + remain;
                remain = remain / 10;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public enum per
        {
            a,
            b,
            c,
            d,
        }
    }
}
