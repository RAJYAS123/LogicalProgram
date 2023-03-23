using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    public class LogicalProgram
    {
        static void Main(string[] args)
        {
            //1
            //23
            //456
            //78910
            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }

            //1
            //12
            //123
            //1234
            //12345
            for (int i = 1; i <=5; i++)   
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            //1
            //22
            //333
            //4444
            //55555
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("hello world");


            //Armstrong number program

            int number = 153;
            int rem;
            int cube;
            int result = 0;
            int temp = number;
            while(number !=0)
            {
                rem = number % 10;
                cube = rem * rem * rem;
                result = result + cube;
                number = number / 10;
            }
            number = temp;
            if(number == result)
            {
                Console.WriteLine("almsrong number");
            }
            else
            {
                Console.WriteLine("not almstrong number");
            }

            //
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <=10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //swapping of number like a=10,b=20
            int a = 10;
            int b = 20;
            Console.WriteLine("Before Swapping of number:a={0},b={1}",a,b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping Of number:a={0},b={1}",a,b);


            int n = 10;
            for (int i = n; i>=0; i--)
            {
                for (int j =0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("-------------------------------");

            int first = 10;
            int second = 20;
            if(a>b)
            {
                Console.WriteLine("a is great");
            }
            else
            {
                Console.WriteLine("b is great");
            }

            Console.WriteLine("-------------------------------");

            int f = 10;
            int s   = 20;
            int t = 30;
            if(a>b&& a>t)
            {
                Console.WriteLine("a is great");
            }
            else if(s>t&&s>f)
            {
                Console.WriteLine("b is great");
            }
            else
            {
                Console.WriteLine("c is great");
            }

            //Console.WriteLine("enter a number");
            //string store = Convert.ToString(Console.ReadLine());
            Console.WriteLine("------------------fibonacci series-------------");
            int k = 0;
            int p = 1;
            int e;
            Console.WriteLine(k);
            Console.WriteLine(p);
            for (int i = 0; i < 10; i++)
            {
                e = k + p;
                Console.WriteLine(e);
                k = p;
                p = e;
            }

            Console.WriteLine("-----------------factrial program1--------------");

            int num = 4;
            int fact = 1;
            for (int i = 1; i <=num ; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);


            Console.WriteLine("-----------------factrial program2--------------");

            int store = Convert.ToInt32(Console.ReadLine());
            int facct = 1;
            for (int i = 1; i<=store; i++)
            {
                facct = facct * i;
            }
            Console.WriteLine(facct);

            Console.WriteLine("-----------------reverse program--------------");

            int numberr = 1234;
            int remm;
            int resultt = 0;
           while(numberr !=0)
            {
                rem = numberr % 10;
                resultt = resultt *10+rem;
                numberr = numberr/10;
            }
            Console.WriteLine(resultt);

            Console.WriteLine("-----------------reverse program2--------------");
            int reverse = Convert.ToInt32(Console.ReadLine());
            int remain;
            int resut = 0;
            while(reverse != 0)
            {
                remain = reverse % 10;
                resut = resut *10+remain;
                reverse= reverse/10;
            }
            Console.WriteLine(resut);
            

            //sum of array values
            int[] arr = new int[10];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;
            arr[6] = 7;
            arr[7] = 8;
            arr[8] = 9;
            arr[9] = 10;
            int sum = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum of array:"+sum);

            Console.WriteLine("-----------------palindrome program2--------------");
            int numberrr = 121;
            int remainr;
            int rest = 0;
            while(numberrr != 0)
            {
                remainr = rest % 10;
                rest= rest*10+remainr;
                numberrr = numberrr/10;
            }
            if (rest==numberrr)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palimdrone");
            }
            Console.WriteLine();

            Console.WriteLine("-----------------palindrome program User Input--------------");
            int numer = Convert.ToInt32(Console.ReadLine());
            int re;
            int res= 0;
            int tempp = numer;
            while(numer != 0)
            {
                re = numer % 10;
                res= res*10 + re;
                numer = numer/10;
            }
            numer = tempp;
            if(numer == res)
            {
                Console.WriteLine("palimdrone number");
            }
            else
            {
                Console.WriteLine("not palimdrone");
            }



            Console.WriteLine("-----------------prime number--------------");
            int prime = 7;
            int countt = 0;
            for (int i = 1; i <=prime ; i++)
            {
                if(prime%i ==0)
                {
                    countt++;
                }
            }
            if(countt == 2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }

            Console.WriteLine("prime number program by user input");
            int prim = Convert.ToInt32((Console.ReadLine()));
            int counter = 0;
            for (int i = 1; i <=prim; i++)
            {
                if(prim%i ==0)
                {
                    counter++;
                }
            }
            if(counter == 2)
            {
                Console.WriteLine("it is prime number");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }

            Console.WriteLine("------------1 to 100 prime number---------");
            for (int numbe = 1; numbe <=100; numbe++)
            {
                int counterr = 0;
                for (int i = 1; i <= numbe; i++)
                {
                    if (numbe % i == 0)
                    {
                        counterr++;
                    }
                }
                if (counterr == 2)
                {
                    Console.WriteLine(numbe);
                }
                
            }
            Console.ReadLine();
        }
    }

}
