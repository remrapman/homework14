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
            int n = 5; //buffer size
            int count = 0;
            int numberOFitarations = 1000000;

            Random rand = new Random();
            Queue defQueue = new Queue(n);

            for (int iteration = 0; iteration < numberOFitarations; iteration++)
            {

                while (!IsFull(count, n)) //Empty
                {

                        int element = rand.Next(100);
                        if (element % 2 == 0)
                        {
                            defQueue.Enqueue(element);
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
                                defQueue.Dequeue();
                                count--;
                            }
                        }
                        iteration++;

                }

                while (IsFull(count, n) && (iteration < numberOFitarations)) //Full
                {
                    for (int i = n; i < numberOFitarations; i++)
                    {
                        int element = rand.Next(100);
                        if (IsFull(count, n))
                        {
                            count = 0;
                        }

                        if (element % 2 == 0)
                        {
                            defQueue.Enqueue(element);
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
                            }
                        }
                        iteration++;
                        count++;
                    }
                }
            }
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
