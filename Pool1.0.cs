using System.Collections.Generic;
using System;

public class Pool<T>
{
    Func<T> _createFunction;
    Queue<T> pool;
    public Pool(Func<T> createFunction)
    {
        _createFunction = createFunction;
        pool = new Queue<T>();
    }
    public T GetItem()
    {
        if (pool.Count > 0)
        {
            return pool.Dequeue();
        }
        return _createFunction();
    }
    public void PutItem(T item)
    {
        pool.Enqueue(item);
    }
}

