using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkApp.Source.Collections
{
    public class List<T> where T : class
    {
        public int Count { get; private set; }

        public bool Empty => Count == 0;

        private Node<T> _head;

        public List()
        {
            _head = null;

            Count = 0;
        }

        public T Get(int index)
        {
            if (Empty) return null;

            if (index < 0 || index >= Count) return null;

            var node = _head;

            var i = 0;

            while(i != index)
            {
                node = node.Next;

                i++;
            }

            return node.Value;
        }

        public void Add(T value)
        {
            Count++;

            if (_head == null)
            {
                _head = new Node<T>(value);

                return;
            }

            var node = _head;
            
            while(node.Next != null)
                node = node.Next;

            node.Next = new Node<T>(value);
        }

        public void AddFront(T value)
        {
            Count++;

            if (_head == null)
            {
                _head = new Node<T>(value);

                return;
            }

            var next = _head;

            _head = new Node<T>(value, next);
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index >= Count) return;

            var i = 0;

            var node = _head;

            var previous = node;

            while(i != index)
            {
                previous = node;

                node = node.Next;

                i++;
            }

            previous.Next = new Node<T>(value, node);

            Count++;
        }

        public T Remove()
        {
            if (Empty) return null;

            var result = _head.Value;

            _head = _head.Next;

            Count--;

            return result;
        }

        public T Remove(T value)
        {
            if (Empty) return null;

            Count--;

            if (_head.Value == value)
            {
                var r = _head.Value;

                _head = _head.Next;

                return r;
            }

            var node = _head;


            while(node.Next != null || node.Next.Value != value)
                node = node.Next;

            var result = node.Next.Value;

            node.Next = node.Next.Next;

            return result;
        }

        public T RemoveLast()
        {
            if (Empty) return null;

            var node = _head;

            while(node.Next != null)
                node = node.Next;

            var result = node.Value;

            node = null;

            Count--;

            return result;
        }

        public void Clear()
        {
            if (Empty) return;

            var node = _head;

            while(node.Next != null)
            {
                var temp = node;

                node = node.Next;

                temp.Next = null;
            }

            Count = 0;
        }


        private class Node<T>(T value, Node<T> next = null)
        {
            public T Value = value;

            public Node<T>? Next = next;
        }
    }
}
