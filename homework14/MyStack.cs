using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14
{

    class MyStack
    {

        public static void Stack()
        {
            int size = 5;
            int[] myarr = new int[size];
            int top = 0;
            Random rand = new Random();

            for (int i = 0; i < 100000000; i++)
            {
                int element = rand.Next(100);
                if (element % 2 == 0)
                {
                    if (IsFull(top, size) == true)
                    {
                        continue;
                    }
                    else
                    {
                        MyStack.Push(myarr, top, element);
                        top++;
                    }
                }

                else
                {
                    if (IsEmpty(top) == true)
                    {
                        continue;
                    }
                    else
                    {
                        Pop(myarr, top);
                        top--;
                    }
                }
            }
        }


        static void Push(int[] arrayFORpush, int top, int Value)
        {

            arrayFORpush[top] = Value;

        }

        static void Pop(int[] arrayFORpop, int b)
        {

            arrayFORpop[b - 1] = 0;
        }

        static bool IsEmpty(int top)
        {
            if (top == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsFull(int top, int size)
        {
            if (top == size)
            {
                return true;
            }
            return false;
        }
    }
}
