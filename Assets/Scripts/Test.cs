using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        NodeList list = new NodeList();
        for (int i = 0; i < 5; i++)
        {
            list.Insert(i);
        }
        print(list.Pop());
        print(list.Empty());
    }
}
