using System;
using System.Collections.Generic;

namespace StackArray
{

    public class StackArray<T> : System.Collections.Generic.IEnumerable<T>
    {
        private T[] _array = new T[0];

        private int _size = 0;

        public int Count
        {
            get { return this._size; }
        }

        public bool IsEmpty()
        {
            return this._size == 0;
        }

        public T Peek()
        {
            if (this._size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int size = this._size-1;
            return this._array[size];
        }

        public T Pop()
        {
            if (this._size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

this._size--;
            T top = this._array[this._size];
            
            return top;
        }

        public void Push(T item)
        {
            if (this._size == this._array.Length)
            {

                int size = this._size == 0 ? 4 : this._size * 2;

                T[] newArray = new T[size];
                this._array.CopyTo(newArray, 0);
                this._array = newArray;

            }

            this._array[this._size] = item;

            this._size++;

            return;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = this._size; i>=0; i--)
            {
                yield return this._array[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this._array.GetEnumerator();
        }

    }






    class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> s = new StackArray<int>();
            s.Push(110);
            Console.WriteLine("Hello World!");
            Console.WriteLine(s.Peek());
        }
    }
}
