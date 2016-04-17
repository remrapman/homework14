using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14
{
    class DefaultStack
    {
        public static void Stack()
        {
            int size = 5;
            int top = 0;
            Random rand = new Random();
            Stack defStack = new Stack(size);

            for (int i = 0; i < 10000; i++)
            {
                int element = rand.Next(100);
                if (element % 2 == 0)
                {
                    if (IsFull(top, size) == true)
                    {
                        return;
                    }
                    else
                    {
                        defStack.Push(element);
                        top++;
                    }
                }

                else
                {
                    if (IsEmpty(top) == true)
                    {
                        return;
                    }
                    else
                    {
                        defStack.Pop();
                        top--;
                    }
                }
            }
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
