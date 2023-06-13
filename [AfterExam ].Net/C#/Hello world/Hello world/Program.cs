using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class rectangle
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4;
            width = 3;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.AcceptDetails();
            r.Display();


            Console.WriteLine("size of char :{0}", sizeof(char));

            double l = 2344.4543;
            int i;
            i = (int)(long)l;
            Console.WriteLine(i);

            int num1;
            int num2;
            int sum;
            Console.WriteLine("First Number");

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");

            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("sum :"+ sum);

            //string FirstName;
            //string LastName;
            //string fullname;
            Console.WriteLine("FirstName");
            string FirstName = Console.ReadLine();
            Console.WriteLine("LastName");
            string LastName = Console.ReadLine();
            string fullname = FirstName +" " +LastName;
            Console.WriteLine("FullName :" + fullname);


            Console.ReadLine();


        }
    }
}
