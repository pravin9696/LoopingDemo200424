using LoopingDemo200424;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
       // create object of myclass12

         myclass12 obj1=new myclass12();

        // call method show using object of myclass12
        //obj1.xyz();
        //obj1.show();
        //obj1.checkEven();

        //Console.WriteLine("end of main method...");

        //int x = 78;

        //if (x==1)
        //{
        //    Console.WriteLine("one");
        //}

        //else if(x==2)
        //{
        //    Console.WriteLine("two");
        //}


        //Console.WriteLine("next line after else if ladder");

        //-------------------------------------------------------------------------------------------------//
        //nested if or nested if else statements
        /*
          if(Condition)
              {
                 if (cond)
                 {

                 }       
              }
          else
        {
          
        }
        */
        int n = 1;

        if (n<3)
        {
            if (n%2==0)
            {
                Console.WriteLine("number is even and less than 3");
            }
            else
            {
                Console.WriteLine("no is odd and less than 3");
            }
        }
        else
        {
            Console.WriteLine("no is greater than 3....");
        }

    }
}