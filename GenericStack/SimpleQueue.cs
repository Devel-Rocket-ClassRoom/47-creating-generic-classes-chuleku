using System;
using System.Collections.Generic;
using System.Text;

public class SimpleQueue<T>
{
    private List<T> _item = new List<T>();
    private int _Count;

    public SimpleQueue(int capacity)
    {
        _item = new List<T>[capacity];
        _Count = 0;
    }
    public virtual void Enqueue(T item)
    {
        if (_Count >= _item.Length)
        {
            throw new InvalidOperationException("큐가 가득 찼습니다");
        }
        _item.Enqueue(item);
    }


}