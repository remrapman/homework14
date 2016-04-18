using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14
{
    class DefQueue
    {

        public static void Queue()
        {
            int size = 5;
            int count = 0;
            int numberOfIterations = 100000000;

            Random rand = new Random();
            Queue defQueue = new Queue(size);

            for (int iterations = 0; iterations < numberOfIterations; iterations++)
            {

                int NewValue = rand.Next(100);
                if (NewValue % 2 == 0)
                {
                    if (IsFull(count, size))
                    {
                        continue;
                    }
                    else
                    {
                        defQueue.Enqueue(NewValue);
                        count++;
                    }
                }

                else
                {
                    if (IsEmpty(count))
                    {
                        continue;
                    }
                    else
                    {
                        defQueue.Dequeue();
                        count--;
                    }
                }
            }
        }

        static bool IsEmpty(int count)
        {

            if (count == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsFull(int count, int size)
        {
            if (count == size)
            {
                return true;
            }
            return false;
        }
    }
}
