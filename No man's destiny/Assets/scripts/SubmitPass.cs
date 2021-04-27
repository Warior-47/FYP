using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubmitPass : MonoBehaviour
{
    private string name1;
    private string password1;
    public GameObject inputField;
    public GameObject password;
    public void StoreName() {
        name1 = inputField.GetComponent<TMP_InputField>().text;
        password1 = password.GetComponent<TMP_InputField>().text;
        Debug.Log("my name iss : " + name1);
        Debug.Log("my password is : " + password1);
    }
    
}
