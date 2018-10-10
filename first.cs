using System;
class MyProg
{
    public static void Main()
    {
            int a,b;
            Console.WriteLine("Enter the value for a and b: ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("a value is Bigger then b");
                Console.ReadKey();
            }
            else if(a==b)
            {
                Console.WriteLine("Value of a and b are same");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("b value is Bigger then a");
                Console.ReadKey();
            }
            
    }
}