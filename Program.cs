using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("it's time to play 3 stacks nim");
            Console.WriteLine("select the amount in stack 1");
            int stack1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select the amount in stack 2");
            int stack2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("select the amount in stack 3");
            int stack3 = Convert.ToInt32(Console.ReadLine());

            while (stack1 != 0 || stack2 != 0 || stack3 != 0)
            {
                Console.WriteLine("the coins in each stack: ");
                Console.Write(stack1);
                Console.Write(" " + stack2);
                Console.Write(" " + stack3);

                Console.WriteLine("pick a stack");
                int selectStack = Convert.ToInt32(Console.ReadLine());
                while (selectStack >= 4 || selectStack <=0)
                {
                    Console.WriteLine("invalid option, try again");
                    selectStack = Convert.ToInt32(Console.ReadLine());

                    
                }
                 
                Console.WriteLine("enter number of tokens to remove");
                int remove = Convert.ToInt32(Console.ReadLine());
                if (selectStack == 1)
                {
                    while (stack1 - remove < 0 || remove == 0)
                    {
                        Console.WriteLine("invalid input, try again");
                        remove = Convert.ToInt32(Console.ReadLine());
                    }
                    stack1 = stack1 - remove;
                }
                else if (selectStack == 2)
                {
                    while (stack2 - remove < 0 || remove == 0)
                    {
                        Console.WriteLine("invalid input, try again");
                        remove = Convert.ToInt32(Console.ReadLine());
                    }
                    stack2 = stack2 - remove;

                }

                else if (selectStack == 3)
                {
                    while (stack3 - remove < 0 || remove == 0)
                    {
                        Console.WriteLine("invalid input try again");
                        remove = Convert.ToInt32(Console.ReadLine());
                    }
                    stack3 = stack3 - remove;

                }
                
                


               
            }
            Console.WriteLine("congratulations to whoever made the most recent move, you have won");
            Console.ReadKey(true);
            
            //Console.ReadKey(true);

           
            





        }
    }
}
