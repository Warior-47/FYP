using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubmitPass : MonoBehaviour
{
    public string name1;
    public GameObject inputField;
    public void StoreName() {
        name1 = inputField.GetComponent<TMP_InputField>().text;
        Debug.Log("my name is : " + name1);
    }
}
