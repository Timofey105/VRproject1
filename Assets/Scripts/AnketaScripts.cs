using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class AnketaScripts : MonoBehaviour
{
    public TMP_InputField NameInputField;
    public TMP_Text nameText;

    public TMP_InputField AgeInputField;
    public TMP_Text AgeTMPText;
    private void Start() {
        NameInputField.onEndEdit.AddListener(NameInputFieldOnEndEdit);
        AgeInputField.onEndEdit.AddListener(AgeInputFielOnEndEdit);
    }
    private void NameInputFieldOnEndEdit(string text) {
        Debug.Log("AnketaScripts::NameInputFieldOnEndEdit(); -- text:" + text);
        OnButtonUserName();
    }
    private void AgeInputFielOnEndEdit(string text) {
        Debug.Log("AnketaScripts::AgeInputFieldOnEndEdit(); -- text:" + text);
        OnButtonUserAge();
    }

    public void OnButtonUserName() {
         Debug.Log("AnketaScripts::NameInputFieldOnEndEdit(); -- NameInputField.text:" + NameInputField.text);
         nameText.text = NameInputField.text;
    }
    public void OnButtonUserAge() {
        Debug.Log("AnketaScripts::AgeInputFieldOnEndEdit(); -- AgeInputField.text:" + AgeInputField.text);
        string ageString = AgeInputField.text ;
        if (ageString != null && ageString.Length > 0) {
            if (int.TryParse(ageString, out int ageInt)) {
                // int AgeInt = int.Parse(ageString);
                DateTime datetime = DateTime.Now;
                datetime = datetime.AddYears(-ageInt);
                AgeTMPText.text = datetime.ToString("yyyy");
            } else {
                AgeTMPText.text = "Нужно только число!";
            }
           
        } else {
            AgeTMPText.text = "Не должно быть пусто!";
        }
        
    }
}
