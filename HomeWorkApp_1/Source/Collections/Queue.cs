using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HomeWorkApp.Source.Collections
{
    public class Queue<T> where T : class
    {
        public int Count { get; private set; }

        public bool Empty => Count == 0;

        private Node<T> _head;

        private Node<T> _tail;

        public Queue()
        {
            Count = 0;
        }

        public T Peek() 
            => _head?.Value;

        public void Enqueue(T value)
        {
            var node = new Node<T>(value);

            Count++;

            if (_tail == null)
            {
                _head = node;

                _tail = node;

                return;
            }

            _tail.Previous = node;
        }

        public T Dequeue()
        {
            if (Empty) return null;

            var result = _head.Value;

            _head = _head.Previous;

            Count--;

            return result;
        }

        private class Node<T>(T value, Node<T> previous = null)
        {
            public T Value = value;

            public Node<T>? Previous = previous;
        }
    }
}
