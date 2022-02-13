using System;

namespace paper_1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentCount = 0;
            int maxCount;
            int[] values = new int[10];
            int temp = 0;

            for(int x = 0; x<values.Length; x = x + 1)
            {
                values[x] = 0;
            }
            
            Console.WriteLine("How many digits?");
            maxCount = Convert.ToInt32(Console.ReadLine());
            while (currentCount < maxCount)
            {
                int insertedValue = Convert.ToInt32(Console.ReadLine());
                values[insertedValue] = values[insertedValue] + 1;
                currentCount = currentCount + 1;
            }

            

            for (int write = 0; write < values.Length; write++)
            {
                for (int sort = 0; sort < values.Length - 1; sort++)
                {
                    if (values[sort] > values[sort + 1])
                    {
                        temp = values[sort + 1];
                        values[sort + 1] = values[sort];
                        values[sort] = temp;
                    }
                }
                
            }
            bool same = true;
            int y = 9;
            while(same == true)
            {
                if (values[y] == values[y - 1]) same = true;
                else same = false;
                Console.WriteLine("{0} ", values[y]);
            }

        }
    }
}
