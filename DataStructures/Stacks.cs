using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stacks
    {
        public static void Main(string[] args)
        {
            //Creating a new stack
            //Stack<string> s = new Stack<string>();
            //s.Push("a");
            //s.Push("b");
            //Debug.WriteLine("The stack contains " + s.Count + " elements");

            //Balanced Braces Problem
            Debug.WriteLine(IsBalanced("{{[]}}").ToString());
            Debug.WriteLine(IsBalanced("((((]").ToString());

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Debug.WriteLine(stack.Pop());
            Debug.WriteLine(stack.Pop());
        }

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c == ')')
                {
                    stackOfClosingBraces.Push(c);
                }
            }

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }

            if ((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
            {
                return false;
            }

            while(stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if((currentClosingBrace == '}' && currentOpeningBrace == '{') ||
                    (currentClosingBrace == ']' && currentOpeningBrace == '[') ||
                    (currentClosingBrace == ')' &&  currentOpeningBrace == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public class Stack
        {
            const int MAX = 1000;
            int top;
            object[] stack = new object[MAX];

            public Stack()
            {
                top = -1;
            }

            public void Push(object obj)
            {
                if(top < MAX)
                {
                    stack[++top] = obj;
                }
            }
            public object Pop()
            {
                if(top >= 0)
                {
                    object o = stack[top];
                    top--;
                    return o;
                }
                else
                {
                    return -1;
                }
            }

            public object Peek()
            {
                return stack[top];
            }
        }
    }
}
