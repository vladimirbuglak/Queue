using System;
using System.Collections.Generic;

namespace Queue
{
    public class Queue<T>
    {
        private Node Head { get; set; }

        private Node Tail { get; set; }

        public void Enqueue(T value)
        {
            if (Head == null)
            {
                Head = Tail = new Node(value, null);
            }
            else
            {
                var node = new Node(value, null);

                if (Head.Next == null)
                {
                    Head.Next = Tail = node;
                }
                else
                {
                    Tail = Tail.Next = node;
                }
            }
        }

        public T Dequeue()
        {
            if (Head == null)
            {
                return default(T);
            }

            var value = Head.Value;
            Head = Head.Next;

            return value;
        }


        public void Print(Action<T> action)
        {
            var node = Head;

            while (node != null)
            {
                action(node.Value);

                node = node.Next;
            }
        }

        public void Clear()
        {
            Head = Tail = null;
        }

        public T Peek()
        {
            if (Head == null)
            {
                return default(T);
            }

            return Head.Value;
        }

        public void Sort<TKey>(Func<T, TKey> selector)
        {
            var node = Head;

            while (node.Next != null)
            {
                var tmpNode = node.Next;

                while (tmpNode != null)
                {
                    if (Comparer<TKey>.Default.Compare(selector(tmpNode.Value), selector(node.Value)) > 0)
                    {
                        var tmp = node.Value;
                        node.Value = tmpNode.Value;
                        tmpNode.Value = tmp;
                    }
                    tmpNode = tmpNode.Next;
                }

                node = node.Next;
            }
        }

        private class Node
        {
            public T Value { get; set; }

            public Node Next { get; set; }

            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }
        }
    }
}
