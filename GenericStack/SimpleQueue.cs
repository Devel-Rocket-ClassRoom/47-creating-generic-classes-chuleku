using System;
using System.Collections.Generic;
using System.Text;

public class SimpleQueue<T>
{
    private T[] _item;
    public int _Count { get; set; }

    public SimpleQueue(int capacity)
    {
        _item = new T[capacity];
        _Count = 0;
    }
    public T  Enqueue(T item)
    {
        if (_Count >= _item.Length)
        {
            Console.WriteLine("큐가 가득 찼습니다.");
            return default(T);
        }
        _item[_Count] = item;
        return _item[_Count++];
    }
    public T Dequeue()
    {
        if(_Count == 0)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T);
        }
        T temp = _item[0];
        for (int i = 1; i < _Count; i++)
        {
            _item[i - 1] = _item[i];
        }
        _Count--;
        return temp;
    }
    public T Peek()
    {
        if (_Count == 0)
        {
            Console.WriteLine("큐가 비어있습니다.");
            return default(T); 
        }
        return _item[0]; 
    }
    public bool IsFull()
    {
        return _Count == _item.Length;
    }
    public bool IsEmpty()
    {
        return _Count == 0;
    }
    public void PrintAll()
    {
        Console.Write("Enqueue ");
        for(int i = 0; i < _item.Length; i++)
        {
            Console.Write(_item[i] + (i == _Count - 1 ? "" : ", "));
        }
    }
}