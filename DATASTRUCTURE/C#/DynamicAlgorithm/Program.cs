using System;

namespace DynamicAlgorithm
{
    class Program
    {

       static int fib(int n)
        {
            int[] term = new int [1000];
            
            if(n == 1)
            {
                return n;
            }
            if(n == 0){
                return n;
            }
             
                if (term[n] != 0)
                {
                      return term[n];
                }else{
                         term[n] = fib(n-1) + fib(n-2);
            return term[n];
                }

        
                        
        }
        static void Main(string[] args)
        {
             Console.WriteLine(fib(8));
        }
    }
}
