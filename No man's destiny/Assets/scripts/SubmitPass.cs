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
    void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {

                app = Firebase.FirebaseApp.DefaultInstance;

                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
            }
        });

        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://final-year-project-511a0-default-rtdb.europe-west1.firebasedatabase.app/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }
    public void StoreName() {
        name1 = inputField.GetComponent<TMP_InputField>().text;
        password1 = password.GetComponent<TMP_InputField>().text;
        Debug.Log("my name iss : " + name1);
        Debug.Log("my password is : " + password1);
        FireBaseDatabase.DefaultInstance.GetReference("Name").ValueChanged += Script_ValueChanged;
        reference.Child("Name").Child("password").GetValue(true).ToString();
    }
    public void GetName(object sender)
    {
        showLoadedText.text = e.Snapshot.Child("Name").Child("Password").GetValue(true).ToString();
    }
    public void LoadUser()
    {
        name1 = inputField.GetComponent<TMP_InputField>().text;
        password1 = password.GetComponent<TMP_InputField>().text;
        Debug.Log("my name iss : " + name1);
        Debug.Log("my password is : " + password1)
    }
  
   
    
}
