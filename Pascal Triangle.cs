
using System;

namespace test_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            input = input + 1;

            Output(input);
        }

        static void Output(int input)
        {
            int i, j, output =1;
            
            for (i = 0; i < input; i++)
            {
               
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 ||i == 0)
                    {
                        output = 1;         // รีค่าตัวแรกใหม่               
                    }                       
                    else
                        output = output * (i - j + 1) / j;
                        Console.Write("{0}   ", output);
                }
                Console.WriteLine("");

                
            }
            Console.ReadLine();
        }
      
    }
}



