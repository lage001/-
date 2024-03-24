using System.Collections.Generic;
using System;

public class Pool<T>
{

    Func<T,T> _createFunction;
    Queue<T> pool;
    T _item;
    int _maxSize;
    public Pool(Func<T,T> createFunction, T item, int maxSize)
    {
        _createFunction = createFunction;
        pool = new Queue<T>();
        _item = item;
        _maxSize = maxSize;
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
        if(pool.Count < _maxSize)
        {
            pool.Enqueue(item);
        }
        else
        {
            IDisposable disposable = item as IDisposable;
            if(disposable != null)
            {
                disposable.Dispose();
            }
        }
        
    }
}

