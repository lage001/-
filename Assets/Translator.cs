using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Translator : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button button;
    void Start()
    {
        button.onClick.AddListener(Lisener);
    }

    private void Lisener()
    {
        List<string> postExp = Functions.ConvertToPost(inputField.text);
        foreach (var item in postExp)
        {
            print(item);
        }
    }
}
