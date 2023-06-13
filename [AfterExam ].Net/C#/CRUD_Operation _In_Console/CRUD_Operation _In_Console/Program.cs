using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation__In_Console
{
    class student
    {
        public string name;
        public int age;
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            student std = new student();
            m:
            Console.WriteLine("===============Welcome to CRUD Operation===============");
            Console.WriteLine("Insert Data : 1");
            Console.WriteLine("Update Data : 2");
            Console.WriteLine("Read Data : 3");
            Console.WriteLine("Delete Data : 4");
            Console.WriteLine("Update Name : 5");
            Console.WriteLine("Update Age : 6");
            Console.WriteLine("Exit : 7");

            //Console.ReadLine();
            int process = 7;
            try
            {
                 process = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                goto m;
            }
            switch (process)
            {
                case 1:
                    
                    Console.WriteLine("Please Enter your name ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please Enter your age ");
                    int age=0;
                    try
                    {
                        age= Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception a)
                    {
                       
                        Console.WriteLine(a.Message);

                    }
                  
                    std.name = name;
                    std.age = age;

                    Console.WriteLine("Process Done ,Data is Saved");
                   
                    goto m;
                case 2:
                    Console.WriteLine("Current name = "+std.name+ "please enter update name");
                    string upname = Console.ReadLine();
                    Console.WriteLine("Current name = " + std.age + "please enter update age");
                    /*int upage = Convert.ToInt32(Console.ReadLine())*/;
                    int upage = 0;
                    try
                    {
                        upage = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception a)
                    {

                        Console.WriteLine(a.Message);

                    }
                    std.name = upname;
                    std.age = upage;
                    Console.WriteLine("Process Done ,Data is Updates");
                    goto m;
                case 3:
                    Console.WriteLine("*************Name*************Age*************");
                    Console.WriteLine("             "+ std.name+"            " + std.age+"     ");
                    //Console.WriteLine("Current name = " + std.name);
                    //Console.WriteLine("Current name = " + std.age);

                    goto m;
                case 4:
                    std.name = null;
                    std.age = 0;
                    Console.WriteLine("Process Done ,Data is Deleted");

                    goto m;

                case 5:
                    Console.WriteLine("Current name = " + std.name);
                    Console.WriteLine("please enter update name");
                    string uname = Console.ReadLine();
                    std.name = uname;
                    Console.WriteLine("Process Done ,Name is Updated now");

                    goto m;
                case 6:

                    Console.WriteLine("Current name = " + std.age);
                    Console.WriteLine("please enter update age");
                    int uage = Convert.ToInt32(Console.ReadLine());                                       
                    std.age = uage;
                    Console.WriteLine("Process Done ,Age is Updated now");
                    goto m;
                case 7:
                    break;

                default:
                    Console.WriteLine("wrong input");
                    goto m;
                    
            }
            
        }
    }
}
