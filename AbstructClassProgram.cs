using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace array
{
   public class AbstructClassProgram
    {
        public abstract class BaseClass
        {
            public abstract void show();    //abstract class can inherit a class and multiple interface
            public abstract void Show2();
        }

        public class ChildClass:BaseClass
        {
            public override void show()
            {
                Console.WriteLine("Class name is BaseClass");
            }

            public override void Show2()
            {
                Console.WriteLine("Show2 Method is here");
            }
        }

        public enum days
        {
            monday,
            tuesday,
            wednusday,
            thursday,
            friday,
            surerday,
            sunday
        }

        public interface ShowAdd
        {
             void yash();
        }

        public class implement : ShowAdd
        {
            public void yash()
            {
                Console.WriteLine("this is a interface method");
            }
        }

        static void Main(string[] args)
        {
            ChildClass childClass = new ChildClass();
            childClass.show();
            childClass.Show2();
            implement obj2 = new implement();
            obj2.yash();
            StringBuilder stringBuilder = new StringBuilder();  //stringbuilder is mutable and string is immutable that can not be chnaged
            var a = stringBuilder.Append("yash").Append("sivemdra");
            Console.WriteLine(a);
            object[] arr = new object[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = "yash";
            arr[3] = 5.12;
            foreach(object item in arr)
            {
                Console.WriteLine(item);
            }
            var person = Tuple.Create(1, "yash",5.2,20,"raj","ambuj",10.50,50);
            //Thread.Sleep(5000);   //for delay the task
            Console.WriteLine(person);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("{0:D}", dateTime);

            Console.WriteLine(days.wednusday);
            Console.ReadLine();
            //BaseClass baseClass = new ChildClass();
            //baseClass.show();
            //baseClass.Show2();
            //Console.WriteLine("hello");
            //int no;
            //int fact = 1;
            //Console.Write("Enter the no");
            //no = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= no; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine(fact);
            //Console.ReadLine();

            //1.reverse string
            //string input = Console.ReadLine();
            //string rev = "";
            //int len = input.Length - 1;
            //while (len >= 0)
            //{
            //    rev = rev + input[len];
            //    len--;
            //}
            //Console.Write("reverse string of {0}",rev);
            //Console.ReadLine();

        //    try
        //    {
        //        DataTable employees = new DataTable("employees");
        //        DataColumn id = new DataColumn("id");
        //        id.Caption = "Emp_Id";
        //        id.DataType = System.Type.GetType("System.Int32");
        //        id.AllowDBNull = false;
        //        id.AutoIncrement = true;
        //        id.AutoIncrementSeed = 10;
        //        id.AutoIncrementStep = 5;
        //        employees.Columns.Add(id);

        //        DataColumn name = new DataColumn("name");
        //        name.Caption = "Emp_Name";
        //        name.DataType = typeof(string);
        //        name.AllowDBNull = false;
        //        name.MaxLength = 50;
        //        name.DefaultValue = "Anonymous";
        //        name.Unique = true;
        //        employees.Columns.Add(name);

        //        DataColumn gender = new DataColumn("gender");
        //        gender.Caption = "Emp_Gender";
        //        gender.DataType = typeof(string);
        //        gender.AllowDBNull = false;
        //        gender.MaxLength = 20;
        //        employees.Columns.Add(gender);

        //        DataColumn salary = new DataColumn("salary");
        //        salary.Caption = "Emp_Salary";
        //        salary.DataType = typeof(int);
        //        salary.AllowDBNull = false;
        //        //salary.MaxLength = 20;
        //        name.DefaultValue = "Anonymous";
        //        employees.Columns.Add(salary);


        //        DataRow row1 = employees.NewRow();
        //        //row1["id"] = 1;
        //        //row1["name"] = "Ali";
        //        row1["gender"] = "Male";
        //        row1["salary"] = 4500;
        //        employees.Rows.Add(row1);

        //        employees.Rows.Add(null, "Anum", "Female",12000);
        //        employees.Rows.Add(null, "Zain", "Male",12000);
        //        employees.Rows.Add(null, "yash", "Male",12000);
        //        employees.Rows.Add(null, "raj", "Male",12000);

        //        employees.PrimaryKey = new DataColumn[] { id };

        //        foreach (DataRow row in employees.Rows)
        //        {
        //            Console.WriteLine(row["id"] + " " + row["name"] + " " + row["gender"] + " " + row["salary"]);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    Console.ReadLine();

        }
    }
}
