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
            int n = 5; //buffer size
            int count = 0;
            int tail = 0;
            int head = 0;
            int numberOFitarations = 1000000;
            int[] myarr = new int[n];
            //bool isEmpty = false;
            Random rand = new Random();
            for (int iteration = 0; iteration < numberOFitarations; iteration++)
            {
                while (!IsFull(count, n)) //Empty
                {
                        int element = rand.Next(100);
                        if (element % 2 == 0)
                        {
                            Enqueue(myarr, element, count);
                            count++;
                            head++;
                        }
                        else
                        {
                            if (IsEmpty(count))
                            {
                                continue;
                            }
                            else
                            {
                                Dequeue(myarr, (count - 1));
                                count--;
                                tail++;
                            }
                        }
                        iteration++;
                }

                while ((iteration >= n) && (iteration < numberOFitarations)) //Full
                {
                        int element = rand.Next(100);
                        if (IsFull(count, n))
                        {
                            count = 0;
                        }

                        if (element % 2 == 0)
                        {
                            Enqueue(myarr, element, count);
                            count++;
                        }
                        else
                        {
                            if (IsEmpty(count))
                            {
                                continue;
                            }
                            else
                            {
                                Dequeue(myarr, (count - 1));
                                count--;
                            }
                        }
                        iteration++;
                }
            }
        }

        //put element in queue
        static void Enqueue(int[] Enq, int b, int i)
        {
            Enq[i] = b;
        }

        //get element from queue(through out parameter, true if element got from queue, false otherwise)
        static void Dequeue(int[] Deq, int i)
        {
            Deq[i] = 0;
        }

        static bool IsEmpty(int a)
        {
            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsFull(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
