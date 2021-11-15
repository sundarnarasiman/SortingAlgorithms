using System;

namespace InsertionSort
{
    class Program
    {
        static int [] num = {8,6,5,7,1,2,3};
        
        static int passcount=0;
        static int swapcount=0;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            InsertionSort();
            PrintedSortedArray();

        }

        static void InsertionSort()


        {

            // Outer loop for passes for keys

            for (int i = 1; i < num.Length-1; i++)
            {

                passcount = passcount+1;

                //Key is the index from which the sorted part begins
                int key = i;

                Console.WriteLine("This is pass number --->"+passcount);

                while(key > 0 && (num[key] < num[key-1]))
                {
                    int temp;
                    temp = num[key];
                   num[key] = num[key-1];
                   num[key-1] = temp;

                   key = key-1;
                   swapcount=swapcount+1;
                   Console.WriteLine("This is swap count ---->"+swapcount);


                }


                
            }
        }

        static void PrintedSortedArray()
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
                
            }
        }


    }
}
