using System;

namespace P_7_FizzBuzz_pro
{
    class Program
    {
        static void Main(string[] args)
        { 
           bool isFizzOrBuzz = false; 
           string FizzBuzzMessage = 
           
            for(int i = 0; i<= 100; i++)
            {
                 if(i % 3 == 0)
                {
                    Console.Write("Fizz");
                }                                 //un truco es usar Console.Write, sin 'Line' para juntar FizzBuzz en una sola linea a no no cierto
                 if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                
            }
        }
        
    }
}
