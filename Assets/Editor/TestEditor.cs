using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class TestEidtor
{
    static Stack stack = new Stack();
    static List<int> intlist = new List<int>() { 1, 2, 3 };
    [MenuItem("CMCmd/栈/push数据")]
    
    public static void Push()
    {
        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }
        Debug.Log(stack.Top());
    }
    [MenuItem("CMCmd/栈/Pop数据")]
    public static void Pop()
    {
        
        Debug.Log(stack.Pop());
    }
    [MenuItem("CMCmd/Test")]
    public static void Change()
    {
        List<int> a = intlist;
        
        foreach (var item in intlist)
        {
            Debug.Log(item);
        }
    }
    [MenuItem("CMCmd/计算")]
    public static void Calculate()
    {
        string exp = "12*3+4-";
        Debug.Log(Functions.PostExp(exp));
    }
}
