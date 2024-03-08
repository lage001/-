using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(Lisener);
    }

    void Lisener()
    {
        string exp = inputField.text;
        print(Functions.PostExp(exp));
    }
}
