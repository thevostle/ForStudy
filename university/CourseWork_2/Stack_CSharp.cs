using System;

namespace StackProgram.Stack
{
    public class ArrayStack<T>
    {
        T[] items;
        private int current = -1;
        private readonly int size = 10;

        public int MaxCount => items.Length;
        public int Count => current + 1;

        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 1;
        }

        public void Push(T data)
        {
            if(current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Стек переполнен");
            }
        }

        public T Pop()
        {
            if(current >= 0)
            {
                var item = items[current];
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
    }
}
