using System;
using System.Reflection;

public abstract class Single<T> where T : class
{
    static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                ConstructorInfo info = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);

                instance = info.Invoke(null) as T;
            }
            return instance;
        }
    }
}
