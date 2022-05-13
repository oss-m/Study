using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        static void Main()
        {
            //Declaring a Variable
            int a = 10;
            double b = 10;
            byte c = 10;
            decimal d = 10;
            char e = 'c';
            string f = "10";
            bool g = true;
            var h = 10;
            dynamic i = 10;

            // Console
            Console.WriteLine();
            Console.ReadLine();

            //implicit Conversion
            byte x = 10;
            int y = x;

            //explicit Conversion (Casting)
            double z = 10;
            int m = (int)z;

            //Parsing
            string v = "10";
            int n = int.Parse(v);

            //Operators
            string assign = "=";
            string math = "+ - / * %";
            string compare = "< > == != <= >=";
            string Logic = "&& ||";

            //Conditinal
            if (x == 10)
            {
                if (x == 20)
                {
                    Console.WriteLine("TRUE");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else if (x == 30)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("false");
            }

            //swich
            switch (x)
            {
                case 10:
                    Console.WriteLine(10);
                    break;
                case 20:
                    Console.WriteLine(20);
                    break;
                default:
                    Console.WriteLine(30);
                    break;
            }

            //Loop for
            for (int i1 = 0; i1 < 3; i1++)
            {
                Console.WriteLine(10);
            }
            int i2 = 0;
            while (i2<5)
            {
                Console.WriteLine(10);
                i2++;
            }
            int i3 = 0;
            do
            {
                Console.WriteLine(10);
                i2++;
            } while (i3 < 5);
            foreach (var item in new List<int>())
            {
                Console.WriteLine(item);
            }

            //Arrays
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[,] arr2 = new int[2, 2];
            Array.Sort(arr);
            int t = arr.Length;

            //Enumeration
            int enu = (int) Classify.A;
            Classify b1 = Classify.B;
            double b2 = b;

            //Date time
            var now = DateTime.Now;
            double year = now.Year;
            var date1 = new DateTime(1990, 8, 14, 5, 6, 12);
            var trans = now - date1;
            var transiant = trans.Hours;

            //string & string builder
            string str = "Hello World";
            str.Contains('H');
            var word = str.Split(' ');

            //string indexing
            Console.WriteLine("{0},{1}", 1, 2);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("World");
            sb.Clear();

            //Files
            string path = @"D:\ Text.txt";
            string path2 = @"D:\ New Fonder";
            File.Create(path);
            Directory.CreateDirectory(path2);

            FileInfo fi = new FileInfo(path);
            fi.Create();
            DirectoryInfo di = new DirectoryInfo(path2);
            di.Create();

            //Dictionary
            var dic = new Dictionary<int,string>();
            dic.Add(1, "One");
            dic.Add(2, "Two");
            foreach (var item in dic)
            {
                string key = item.Value;
                int val = item.Key;
            }
            var dic2 = new Dictionary<int, string>()
            {
                {1, "One"},{2, "Two"}
            };
            foreach (var item in dic2)
            {
                string key = item.Value;
                int val = item.Key;
            }
            //Declare a class
            Student stu = new Student();
            var stu2 = new Student();
            //class members-fields
            stu.Id = 10;
            //static field
            Student.Group = "K";
            //class members-methods
            stu.Per();
            //static method
            Student.Groups();
            //constructor
            var stu3 = new Student();
            var stu4 = new Student("A");
            var stu5 = new Student("A", 50);
            var stu6 = new Student("A", 50, 20.5);
            //List
            List<Student> stulist = new List<Student>();
            int count = stulist.Count;
            //object intializer
            var stu7 = new Student() { Grade = 3.2, Id = 5, Name = "x" };
            //params
            Sum(10, 20, 30, 40);
            //value by ref
            int xt = 10; int yt = 20;
            Cl.Swap(ref xt, ref yt);
            //inheritance-constructor inheritance
            Parents parent = new Parents("name");
            parent.ParentNames.Add(new Parents("baba"));
            parent.ParentNames.Add(new Parents("mama"));
            //upcasting
            Student s = parent;
            s.Height = 20;
            //downcasting
            Parents P = stu as Parents;
            if (P != null) { P.Height = 10; }
            if (P is Parents) { Parents P2 = (Parents)stu; }
            //Boxing&unBoxing
            int num1 = 10; object num2 = num1; int num3 = (int)num2;
            //nullable
            string nullstr = "";
            int? nulls = int.Parse(nullstr);
            //exeption handling
            try
            {
                Console.WriteLine("try to do somthing");
            }
            catch (Exception et)
            {
                Console.WriteLine(et.Message);
            }
            finally
            {
                Console.WriteLine("do somthing");
            }
            //LINQ
            var students = new List<Student>();
            var students1 = students.Where(bt => bt.Grade < 50);
            var students2 = students.OrderBy(bt => bt.Name);
            var students3 = students.OrderByDescending(bt => bt.Name);
            var students4 = students.First();
            var students5 = students.Last();
            var students6 = students.Single();
            var students7 = students.FirstOrDefault(); if (students7 != null) { string firstname = students7.Name; };
            var students8 = students.LastOrDefault(); if (students8 != null) { string lastname = students8.Name; };
            var students9 = students.SingleOrDefault(); if (students9 != null) { string lastname = students9.Name; };
            var students10 = students.Select(bt => bt.Name);
            var students11 = students.Max(bt => bt.Grade);
            var students12 = students.Min(bt => bt.Grade);
            var students13 = students.Sum(bt => bt.Grade);
            var students14 = students.Average(bt => bt.Grade);
        }
        //Methods
        public static void Sum1()
        {
            Console.WriteLine("Sum");
        }
        public static int Sum2()
        {
            return 10;
        }
        public static void Sum1(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static int Sum2(int x, int y)
        {
            return x+y;
        }

        // Enumeration
        public enum Classify
        {
            A = 10, 
            B = 20,
            C = 30
        }
        //Declare a class
        public class Student : IStudent
        {
            //class members-fields
            public int Id;
            public string Name;
            public double Grade;
            //static field
            public static string Group;
            //read only fields
            readonly string school;
            //properties
            private int _Height;
            public int Height
            {
                get { return _Height; }
                set { _Height = value; }
            }
            public int Height2 { get; set; }
            //composition
            public List<Parents> ParentNames { get; set; }
            //composition
            public Student() { ParentNames = new List<Parents>(); }
            //constructor, overloading, chaining
            public Student(string Name) : this() { this.Name = Name; }
            public Student(string Name, int Id) : this(Name) { this.Id = Id; }
            public Student(string Name, int Id, double Grade) : this(Name, Id) { this.Grade = Grade; }
            //class members-methods
            public void Add() { }
            //method overriting
            public virtual void Add2() { }
            public double Per() { return Grade / 100; }
            //static method
            public static string Groups() { return Group; }
            //metod overloading
            public void meth(string Name) { this.Name = Name; }
            public void meth(string Name, double Grade) { this.Name = Name; this.Grade = Grade; }
            public void meth(string Name, int Id) { this.Name = Name; this.Id = Id; }
        }
        //params
        public static void Sum(params int[] numbers) { int average = numbers.Sum(); }
        //value by ref
        public class Cl
        {
            public int x;
            public int y;
            public static void Swap(ref int x, ref int y) { int temp = x; x = y; y = temp; Console.WriteLine("{0}\n{1}", x, y); }
        }
        //inheritance
        public class Parents : Student
        // Constructor inheritance
        {
            public Parents(string name) : base(name) { this.Name = name; }
            //method overriting
            public override void Add2() { }
        }
        //abstract
        public abstract class Shape
        {
            public abstract void Abs();
        }
        public class Square : Shape
        {
            public override void Abs() { }
        }
        //Interface
        public interface IStudent
        {
            void Add();
            void Add2();
            double Per();
            void meth(string Name);
            void meth(string Name, double Grade);
            void meth(string Name, int Id);
        }
        //Generic list
        public class GenericListr<T>
        {
            public List<T> Add;
            public List<T> Adds(List<T> addad) { return this.Add; }
        }
    }
    //Extension method
    public static class StringExtention
    {
        public static string Shorten(this string str, int num) { return str; }
    }
}
