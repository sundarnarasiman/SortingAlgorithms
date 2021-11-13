using System;

namespace SelectionSort
{
    class Program
    {
        static int [] num = {8,6,5,7,1,2,3};
        static int swapcount = 0;
        static int swapcheck = 0;
        static void Main(string[] args)
        {
           
            SelectionSort();
            PrintSortedItems();
        }

        static void SelectionSort()
        {
         
           //Outer loop for number of passes till n-2 th item in the array
            for (int i = 0; i < num.Length-1; i++)
            {
                   int minIndex = i;
                   int passcount = i+1;
                
                Console.WriteLine("This is pass number ----->"+passcount);

                //Inner loop for checking to perform a swap
                for (int j = i+1; j < num.Length; j++)
                {
                    swapcheck = swapcheck+1;
                    Console.WriteLine("  This check for swap -->"+swapcheck);
                    if (num[i]>num[j])
                    {
                        swapcount=swapcount+1;
                        int temp;
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;

                        Console.WriteLine("         This is swap count------->"+swapcount);

                        //minIndex = j;

                    }

                }
                
            }
        }

        static void PrintSortedItems()
        {
            Console.WriteLine("Printing sorted array");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
