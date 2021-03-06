/*using System;
using System.Globalization;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int val;
            bool found = false;
            int[] num = new int[10];
            for(i=0;i<10;i++)
            {
                num[i] = i; 
            }
            val = 5;

            foreach(int x in num)
            {
                Console.WriteLine("value Found" + x);
                if (x==val)
                {
                    
                    found = true;
                    break;
                }
            }
            if(found)
            {
                Console.WriteLine("value Found");
            }
        }
    }
}
// String Topic Using Method function 
using System;
using System.Globalization;

namespace Method
{
    class StringMethod
    {
        static void Main()
        {
            string str1 = "When it comes to .NET programming, C# is #1.";
            string str2 = "When it comes to .NET programming, C# is #1.";
            string str3 = "C# strings are powerful.";
            string strUp, strLow;
            int result, idx;
            Console.WriteLine("str1 String Print -" + str1);
            Console.WriteLine("Str1 String Lenght" + str1.Length);
            strUp = str1.ToUpper(CultureInfo.CurrentCulture);
            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            Console.WriteLine("String is Upper Case\t" + strUp);
            Console.WriteLine("String is Lowercase\t" + strLow);

            Console.WriteLine();

            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
            }
            Console.WriteLine("\n");

            if (str1 == str2)
            {
                Console.WriteLine("Str1==str2");
            }
            else
            {
                Console.WriteLine("str1 != Str2");
            }
            if (str1 == str3)
            {
                Console.WriteLine("Str1==str3");
            }
            else
            {
                Console.WriteLine("str1 != Str3");
            }
            result = string.Compare(str1, str3, StringComparison.CurrentCulture);
            if(result==0)
            {
                Console.WriteLine("str1 and str3 is equal");
            }
            else if(result<0)
            {
                Console.WriteLine("Str1 is  Less then str3");
            }
            else
            {
                Console.WriteLine("str1 is greater then  str3");
            }
            Console.WriteLine();

            str2 = "One Two Three One";
            idx = str2.IndexOf("One", StringComparison.Ordinal);
            Console.WriteLine("Index of first occurrence of One: " + idx);
            idx = str2.LastIndexOf("One", StringComparison.Ordinal);
            Console.WriteLine("Index of last occurrence of One: "+idx);
        }
    }
}}

// write a Program Sub String  Display
using System;
namespace String
{
    class Substring
    {
        static void Main(string [] arge)
        {
            string orstr= "C# makes strings easy.";
            string substr = orstr.Substring(2, 15);
            Console.WriteLine("Or String " + orstr);
            Console.WriteLine("sub string " + substr);
        }
    }
}

//  Objects are passed by reference.
using System;

namespace ObjectRef
{
    class Object
    {
        public int a, b;
        public Object(int i, int j)
        {
            a = i;
            b = j;
        }
    
     public void Change(Object obj)
     {
        obj.a = obj.a + obj.b;
        obj.b = -obj.b;
     }
    }
    class ObjcetDome
    {
        static void Main(String [] are)
        {
            Object obj1 = new Object(25, 25);
            Console.WriteLine("Before Call Value A= " + obj1.a + " B =" + obj1.b);
            obj1.Change(obj1);
            Console.WriteLine("After Call Value A=" + obj1.a + " B =" + obj1.b);
        }
    }
}

//// Demonstrate params.
using System;
namespace ParameDemo
{
    class Test
    {
       public int MinVal(params int[] nums)
        {
            int m;
            if(nums.Length==0)
            {
                Console.WriteLine("Error No Value ");
                return 0;
            }
            m = nums[0];
            for(int i=1;i<nums.Length;i++)
            {
                if(nums[i] < m) 
                {
                    m = nums[i];
                }
               
               
            }
            return m;
        }
        class ParamsDemo
        {
         public static void Main()
            {
                Test obj =new Test();
                int min, a = 20, b = 30;
                min = obj.MinVal(a, b);
                Console.WriteLine("Minimum value is " + min);
                min = obj.MinVal(a, b, 1);
                Console.WriteLine("Minimum value is " + min);
                min = obj.MinVal(12, 14, 15, 18, 14, 19, 2, 58, 21, 95);
                Console.WriteLine("Minimum value is " + min);
                min = obj.MinVal(51, 52, 54, 45, 95, 69, 65, 35);
                Console.WriteLine("Minimum value is " + min);
            }
        }
    }
}

//Use regular parameter with a params parameter.

using System;
namespace TeatParams
{
    class Test
    {
        public void ShowArrays(string msg, params int[] nums)
        {
            Console.WriteLine(msg + ": ");
            foreach(int i in nums)
            {
                Console.Write(i + ":");
            }
            Console.WriteLine();
        }
    }
    class ParamsDemo
    {
        public static void Main(String []array)
        {
            Test ob = new Test();
            ob.ShowArrays("Here are some integers ", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
            ob.ShowArrays("Heare are Two Same Value", 20, 24, 21, 20);

        }
    }
}

// Return an object.

using System;
namespace ReturnObject
{
    class Rect
    {
        int heigth;
        int width;
        public Rect(int w, int h)
        {
            width = w;
            heigth = h;
        }
        public int Area()
        {
            return width * heigth;
        }
        public void show()
        {
            Console.WriteLine(width + ":" + heigth);
        }
        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, heigth * factor);// Create Returnig Object Syntex
        }
    }
    class ReturnObjectDemo
    {
        public static void Main(String[] ages)
        {
            Rect obj = new Rect(10, 15);
            Console.WriteLine("Dimensions Rect Obj");
            obj.show();
            int value = obj.Area();
            Console.WriteLine("Area is : " + value);
        Rect r2 =obj.Enlarge(2);
            Console.WriteLine("Array Enlarge Value");
            r2.show();
        }
    }
}

// Use Class Factory
using System;
namespace Classfactory
{
    class Myfactory
    {
        int a, b;
        public Myfactory Factory(int i, int j)// Factory Method s Craete 
        {
            Myfactory t = new Myfactory();
            t.a = i;
            t.b = j;
            return t;
        }
        public void Show()
        {
            Console.WriteLine(" A and B Value Display A: " + a + "\tB=" + b);
        }
    }
    class ClassFactoryDemo
    {
        public static void Main(String [] Ager)
        {
            Myfactory obj = new Myfactory();
            int i, j;
            for (i = 0, j = 10; i < 10;i++,j--)
            {
                Myfactory obj2 = obj.Factory(i, j);// Factory Method call By ref Object
                obj2.Show();
            }
            Console.WriteLine();
        }
    }
}

//// Demonstrate method overloading.

using System;
namespace Overloding
{
    class MethodOverloding
    {
        public void MethodOver()
        {
            Console.WriteLine("No Parameter Pass");
        }
        public void MethodOver(int a)
        {
            Console.WriteLine("A one  Parameter Pass" + a);
        }
        public int MethodOver(int a, int b)
        {
            Console.WriteLine("Two parameter Pass " + a + ":" + b);
            return a + b;
        }
        public double MethodOver(double a,double b)
        {
            Console.WriteLine("Double value Pass Paramater" + a + ":" + b);
            return a + b;
        }
    }
    class MethodOverlodingDemo
    {
        public static void Main(String[] arge)
        {
            int res;
            double result;
            MethodOverloding obj = new MethodOverloding();
            obj.MethodOver();
            Console.WriteLine();
            obj.MethodOver(2);
            Console.WriteLine();
            res= obj.MethodOver(4,8);
            Console.WriteLine("Integer Value:"+ res);
            result = obj.MethodOver(25.2, 30.5);
            Console.WriteLine("Double value:" + result);


        }
    }
}

// Demonstrate an overloaded constructor.
using System;
namespace MethodOverlodingCons
{
    class MyMethodOverloding
    {
       public int x;
        public MyMethodOverloding()
        {
            Console.WriteLine("No value pass Parametre inside class MyMethodOverloding(): ");
             x = 0;
        }
        public MyMethodOverloding(int a)
        {
            Console.WriteLine("Inside MyClass(int) : ");
              x = a;
        }
        public MyMethodOverloding( double d)
        {
            Console.WriteLine("Inside MyClass(double).");
            x = (int)d;
        }
        public MyMethodOverloding(int i, int j)
        {
            Console.WriteLine("Inside MyClass(int, int).");
            x = i * j;
        }
    }
    class OverloadConsDemo
    {
        static void Main()
        {
            
            MyMethodOverloding t1 = new MyMethodOverloding();
            MyMethodOverloding t2 = new MyMethodOverloding(88);
            MyMethodOverloding t3 = new MyMethodOverloding(17.23);
            MyMethodOverloding t4 = new MyMethodOverloding(2, 4);
            Console.WriteLine("t1.x: " + t1.x);
            Console.WriteLine("t2.x: " + t2.x);
            Console.WriteLine("t3.x: " + t3.x);
            Console.WriteLine("t4.x: " + t4.x);
        }
    }
}

// A stack class for characters.
using System;
namespace stackDeveloper
{
    class Stack
    {
      char[] stck;
       int tos;
    
     public Stack(int size)
     {
        stck = new char[size];
        tos = 0;
     }
     public Stack(Stack ob)
     {
        stck =new char [ob.stck.Length];
        for(int i=0;i<ob.tos;i++)
        {
            stck[i] = ob.stck[i];
        }
        tos = ob.tos;

     }
        public void Push(char ch)
        {
            if (tos == stck.Length)
            {
                Console.WriteLine("---Stack Is full-- ");
                return;
            }
            stck[tos] = ch;
            tos++;
        }
        public char Pop()
        {
            if (tos == 0)
            {
                Console.WriteLine("--Stack Is Empty--");
                return (char)0;
            }
            tos--;
           return stck[tos];
        }
        public bool IsStackFull()
        {
            return tos == stck.Length;
        }
        public bool IsStackEmpty()
        {
            return tos == 0;
        }
        public int Capacity()
        {
            return stck.Length;
        }
        public int GetNum()
        {
            return tos;
        }
     }
    class StackClass
    {
        public static void Main(String  [] agre)
        {
            int i;
            char ch;
            Stack obj = new Stack(20);
           

        }
    }
}

// Demonstrate invoking a constructor through this using this keyword.
using System;
namespace invokeConst
{
    class XYCoord
    {
        public int x;
        public int y;
        public XYCoord() :this(0,0)
        {
            Console.WriteLine("XY Coord Inside()");
        }
        public XYCoord(XYCoord obj):this(obj.x,obj.y)
        {
            Console.WriteLine("XY coord Inside Object(obj,obj)");
        }
        public XYCoord(int i,int j)
        {
            Console.WriteLine("XYCoord Inside Object(int, int )");
            x = i;
            y = j;

        }
     
    }
    class OverLoadsDemo
    {
        public static void Main(String[] ager) 
        {
            XYCoord t1 = new XYCoord();
            XYCoord t2 = new XYCoord(8, 9);
            XYCoord t3 = new XYCoord(10, 20);
            XYCoord t4 = new XYCoord(t3);
            Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);
            Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
            Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);
            Console.WriteLine("t4.x,t4.y:" + t4.x + "," + t4.y);
        }
    }
}

// A simple demonstration that uses object initializers.
using System;
namespace ObjectIni
{
    class Objinitializers
    {
        public int Id;
        public string First_Name;
        public string Lest_Name;
        public int Moblie_number;

    }
    class ObjinitializersDemo
    {
        public static void Main()
        {
            Objinitializers obj = new Objinitializers
            { Id = 10102, First_Name = "Ranjeet", Lest_Name = "Patel", Moblie_number = 799875809 };
            Console.WriteLine("\t EMPLYEE DATA\n\t ID\n"+ obj.Id + " First Name\n\t" + obj.First_Name + "\n  Lest Name\t" + obj.Lest_Name + "\n  Moblie Number\t" + obj.Moblie_number);
        }

    }
}

// Demonstrate optional arguments.
using System;
namespace OplArMathDemo
{
    class OplArMath
    {
        static void OplArgMeth(int Alpa, int beta = 10, int gamma = 20)
        {
            Console.WriteLine("Hare Value Is Alpa Beta Gamma" + Alpa + ":" + beta + ":" + gamma);
        }
        public static void Main()
        {
            OplArgMeth(1, 2, 3);
            OplArgMeth(1, 2);
            OplArgMeth(1,2);
        }
    }
}

// Use an optional argument to simplify a call to a method.
using System;
namespace OptArgMathDemo
{
    class OptArgMath
    {
        static void display(string str,int start=0,int stop = -1)
        {
            if(stop<0)
            {
                stop = str.Length;
            }
            if(stop>str.Length|start>stop|start<0)
            {
                return;
            }
            for(int i=start;i<stop;i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            display("This is a test");
            display("This is a Test ", 5);
            display("This is a Test", 6);
            display("This is a Test", 7);
            display("This is a test ", 8);
            display("This is a test Number", 12, 15);

        }
    }
}

// Use named arguments.
using System;
namespace NamedAlr
{
    class NamedAlrDemo
    {
        static bool IsFactory(int val,int divisor)
        {
            if((val%divisor)==0)
            {
                return true;
            }
            return false;
        }
         static void Main()
        {
            if(IsFactory(10,2))
            {
                Console.WriteLine("2 is a factory of 10");
            }
            if(IsFactory(val:10,divisor:2))
            {
                Console.WriteLine("2 is a factory of 10");
            }
            if(IsFactory(10,divisor:2))
            {
                Console.WriteLine("2 is a factory of 10");
            }
            if (IsFactory(val:10, 2))
            {
                Console.WriteLine("2 is a factory of 10");
            }
        }
    }
}

// This is a recursive method.
using System;
namespace RecursiveDemo
{
    class Factorial
    {
        public int FactR(int n)
        {
            int result;
            if (n == 1) 
                return 1;
            result = FactR(n - 1) * n;
            return result;
        }
    }
    class RecorsiveDemo
    {
        public static void Main()
        {
            Factorial obj = new Factorial();
            Console.WriteLine("Factorials using recursive method");

            Console.WriteLine("Factorials of 4 is " + obj.FactR(4));
            Console.WriteLine("Factorials of 5 is " + obj.FactR(5));
            Console.WriteLine("Factorials of 6 is " + obj.FactR(6));
            Console.WriteLine("Factorials of 7 is " + obj.FactR(7));
            Console.WriteLine("Factorials of 8 is " + obj.FactR(8));
            Console.WriteLine("Factorials of 9 is " + obj.FactR(9));
        }
    }
}

// Use static.
using System;
namespace staticDemoS
{
   class StaticDemo
    {
        public static int val = 100;
   
     public static int valDiv2()
     {
        return val/ 2;
     }
    }
    class Static
    {
     public static void Main()
        {
          Console.WriteLine("Sample Static Value Print "+ StaticDemo.val);
          StaticDemo.val = 8;
         Console.WriteLine(" Static Value change of "+ StaticDemo.val);
         
            Console.WriteLine(" Static Value change of div function called  " + StaticDemo.valDiv2());

        }
    }
}
*/