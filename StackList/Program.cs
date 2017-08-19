using System;
using System.Collections.Generic;

namespace StackList
{

    public class StackList<T> : System.Collections.Generic.IEnumerable<T>
    {

        System.Collections.Generic.LinkedList<T> _list = new System.Collections.Generic.LinkedList<T>();

        public bool IsEmpty()
        {
            return this._list.Count == 0;
        }

        public void Push(T item)
        {
            this._list.AddLast(item);
        }


        public T Pop()
        {
            if (this._list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T firstNode = this._list.First.Value;
            this._list.RemoveFirst();
            return firstNode;
        }

        public T Peek()
        {
            if (this._list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T firstNode = this._list.First.Value;
            this._list.RemoveFirst();
            return firstNode;
        }

        public int Count
        {
            get { return this._list.Count; }
        }

        public void Clear()
        {
            this._list.Clear();
        }


        public IEnumerator<T> GetEnumerator()
        {
            return this._list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this._list.GetEnumerator();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StackList<int> s = new StackList<int>();
            s.Push(1);
            Console.WriteLine(s.Peek());
        }
    }
}
