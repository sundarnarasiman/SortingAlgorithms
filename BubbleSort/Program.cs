using System;

namespace BubbleSort
{
    class Program
    {
         static int [] num = {7,6,5,4,3,2,1};
        static void Main(string[] args)
        {
           
            // Total number of passes for swap it is 0 to arr.length-1
           for (int k=0;k<num.Length-1;k++)
           {
           PassAndSwap(num,k);
            }
           PrintSortedArray(num);
            Console.WriteLine("Hello World!");
        }



        public static void PassAndSwap(int [] input, int pass)
        {
            // Total number of swaps = 0 to arr.length-swap_iteration-1
            for (int i=0; i<input.Length-pass-1;i++)
            {

                if (input[i] > input[i+1])
                {
                    int temp;
                    temp = input[i];
                    input[i]=input[i+1];
                    input[i+1]=temp;
                   
                }
            }
            PrintSortedArray(num);

        }

       
           
        

        public static void PrintSortedArray(int [] Sorted)
        {
            for (int j = 0 ;j<Sorted.Length;j++)
            {
                Console.WriteLine(Sorted[j]+",");
               
            }
             Console.WriteLine("\n");

        }
    }
}
