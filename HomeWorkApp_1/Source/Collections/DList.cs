using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkApp.Source.Collections
{
   public class DList<T>
{
    public int Count { get; private set; }

    public bool Empty => Count == 0;

    private T[] Memory;

    private int _size;

    public DList(int size)
    {
        Count = 0;
        _size = size;
        Memory = new T[_size];
    }

    public DList(DList<T> content)
    {
        Memory = content.Memory.ToArray();
        _size = content._size;
        Count = content.Count;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= Count) throw new KeyNotFoundException();
        return Memory[index];
    }

    public void Add(T value)
    {
        if (Count == _size)
        {
            _size = _size + 4;
            var newMemory = new T[_size];
            for (int i = 0; i < Count; i++)
                newMemory[i] = Memory[i];
            Memory = newMemory;
        }

        Memory[Count] = value;
        Count++;
    }

    public void AddFront(T value)
    {
        if (Count == _size)
        {
            _size = _size + 4;
            var newMemory = new T[_size];
            for (int i = 0; i < Count; i++)
                newMemory[i] = Memory[i];
            Memory = newMemory;
        }

        for (int i = Count; i > 0; i--)
        {
            Memory[i] = Memory[i - 1];
        }

        Memory[0] = value;
        Count++;
    }

    public void Insert(int index, T value)
    {
        if (index < 0 || index > Count) throw new IndexOutOfRangeException();

        if (Count == _size)
        {
            _size = _size + 4;
            var newMemory = new T[_size];
            for (int i = 0; i < Count; i++)
                newMemory[i] = Memory[i];
            Memory = newMemory;
        }

        for (int i = Count; i > index; i--)
        {
            Memory[i] = Memory[i - 1];
        }

        Memory[index] = value;
        Count++;
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= Count) throw new IndexOutOfRangeException();

        T value = Memory[index];

        for (int i = index; i < Count - 1; i++)
        {
            Memory[i] = Memory[i + 1];
        }

        Memory[Count - 1] = default(T);
        Count--;
    }

    public bool Remove(T value)
    {
        int index = Find(value);
        if (index == -1) return false;

        Remove(index);
        return true;
    }

    public int Find(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(Memory[i], item))
                return i;
        }
        return -1;
    }

    public override string ToString()
    {
        return string.Join(", ", Memory, 0, Count);
    }
}
}
