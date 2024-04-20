using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LoopingDemo200424
{
    
    internal class myclass12
    {
        private int x = 5;

        public void mymsg()
        {
            Console.WriteLine("this is msg from xyz");
        }
        public void xyz()
        {
            int z = x;
            mymsg();
        
        }
        public void show()
        {
            mymsg();
            int p = x;
            x = x + 4;
            // conditional statements

            // if
            //if else
            //if else ladder  //else if ladder
            //nested if

            //switch

            //if conditional statement

            //synatx
            /*
                if(condition)
                  {


                  }
             */
            int a = 5;
            if(a>10)
            {
                Console.WriteLine("greater");
            }
            Console.WriteLine("next line....");
        }
        public void checkEven()
        {
            int n;
            Console.WriteLine("Enter number:");
            n=Convert.ToInt32( Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine(n+" is even");
            }
            else
            {
                Console.WriteLine(n+" is odd number");
            }
        }
    }
}
