using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14
{
    class MyQueue
    {
        public static void Queue()
        {
            int size = 5;
            int[] myarr = new int[size];
            int head = 0;
            int tail = 0;
            int count = 0;
            int numberOfIterations = 100000000;
            
            Random rand = new Random();

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
                        if (tail == size)
                        {
                            tail = 0;
                        }
                        Enqueue(myarr, tail, NewValue);
                        tail++;
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
                        if (head == size)
                        {
                            head = 0;
                        }
                        Dequeue(myarr, head, size);
                        head++;
                        count--;
                    }
                }
            }
        }

        static void Enqueue(int[] arrayFORenqueue, int tail, int Value)
        {
            arrayFORenqueue[tail] = Value;
        }

        static void Dequeue(int[] arrayFORdequeue, int b, int size)
        {
            if (b == size)
            {
                b = 0;
            }
            arrayFORdequeue[b] = 0;
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
