using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        Stack list = new Stack();
        for (int i = 0; i < 5; i++)
        {
            list.Push(i);
        }
        print(list.Pop());
        print(list.IsEmpty());
    }
}
