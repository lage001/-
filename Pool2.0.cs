using System.Collections.Generic;
using System;

public class Pool<T>
{

    Func<T, T> _createFunction;
    Queue<T> pool;
    T _item;
    public Pool(Func<T, T> createFunction, T item)
    {
        _createFunction = createFunction;
        pool = new Queue<T>();
        _item = item;
    }

    public T GetItem()
    {
        if (pool.Count > 0)
        {
            return pool.Dequeue();
        }
        return _createFunction(_item);
    }
    public void PutItem(T item)
    {
        pool.Enqueue(item);
    }
}

