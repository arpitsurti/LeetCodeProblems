﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*232. Implement Queue using Stacks
     * Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

        Implement the MyQueue class:

        void push(int x) Pushes element x to the back of the queue.
        int pop() Removes the element from the front of the queue and returns it.
        int peek() Returns the element at the front of the queue.
        boolean empty() Returns true if the queue is empty, false otherwise.
        Notes:

        You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
        Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.
 
        Example 1:
        Input
        ["MyQueue", "push", "push", "peek", "pop", "empty"]
        [[], [1], [2], [], [], []]
        Output
        [null, null, null, 1, 1, false]

        Explanation
        MyQueue myQueue = new MyQueue();
        myQueue.push(1); // queue is: [1]
        myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
        myQueue.peek(); // return 1
        myQueue.pop(); // return 1, queue is [2]
        myQueue.empty(); // return false
 
        Constraints:
        1 <= x <= 9
        At most 100 calls will be made to push, pop, peek, and empty.
        All the calls to pop and peek are valid.

        Follow-up: Can you implement the queue such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.
    */
    public class MyQueue
    {
        Stack<int> st;
        Stack<int> queue;
        public MyQueue()
        {
            st = new Stack<int>();
            queue = new Stack<int>();
        }

        public void Push(int x)
        {
            while (queue.Count != 0)
            {
                st.Push(queue.Pop());
            }
            st.Push(x);
            while (st.Count != 0)
            {
                queue.Push(st.Pop());
            }
        }

        public int Pop()
        {
            if (queue.Count != 0)
                return queue.Pop();
            else
                return -1;
        }

        public int Peek()
        {
            return queue.Peek();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
