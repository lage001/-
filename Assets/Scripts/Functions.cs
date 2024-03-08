using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class Functions
{
    static Dictionary<string, int> priority = new Dictionary<string, int>()
    {
        {")",0},{"-",1},{"+",1},{"/",2},{"*",2},{"(",3}
    };
    public static int PostExp(string exp)
    {
        
        List<string> explist = ConvertToList(exp);
        
        Stack<int> numStack = new Stack<int>();
        foreach (var item in explist)
        {
            if (IsOperator(item))
            {
                int a = numStack.Pop();
                int b = numStack.Pop();
                numStack.Push(Calculate(b, a, item));
            }
            else
            {
                int num = int.Parse(item);
                numStack.Push(num);
            }
        }
        return numStack.Pop();
    }
    public static List<string> ConvertToPost(string midExp)
    {
        List<string> postExp = new List<string>();
        List<string> expList = ConvertToList(midExp);
        Stack<string> symbolStack = new Stack<string>();
        foreach (var item in expList)
        {
            string top;
            if (item == ")")
            {
                while (symbolStack.TryPop(out top))
                {
                    if (top != "(")
                        postExp.Add(top);
                }
            }
            else if (item == "(")
            {
                symbolStack.Push(item);
            }
            else if (IsOperator(item))
            {
                
                while (symbolStack.TryPop(out top) && priority[item] <= priority[top] && top != "(")
                {
                    postExp.Add(top);
                }
                symbolStack.Push(top);
                symbolStack.Push(item);
            }
            else
            {
                postExp.Add(item);
            }
        }
        return postExp;
    }
    public static bool IsOperator(string str)
    {
        List<string> operators = new List<string>() { "+", "-", "*", "/","(",")"};
        if (operators.Contains(str))
        {
            return true;
        }
        return false;
    }

    public static int Calculate( int a, int b, string op)
    {
        if(op == "+")
            return a + b;
        if (op == "-")
            return a - b;
        if (op == "*")
            return a * b;
        if (op == "/") 
            return a / b;
        return -1;
    }
    static List<string> ConvertToList(string exp)
    {
        List<string> strList = new List<string>();
        exp = "(" + exp + ")";
        foreach (var item in exp)
        {
            string i = item.ToString();
            if (IsOperator(i) || int.TryParse(i,out int result))
            {
                strList.Add(i);
            }
        }
        return strList;
    }
}
