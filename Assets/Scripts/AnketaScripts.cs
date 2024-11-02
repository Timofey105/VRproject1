using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnketaScripts : MonoBehaviour
{
    public TMP_InputField NameInputField;
    public TMP_Text nameText;

    public void OnButtonUserName()
    {
        nameText.text = NameInputField.text;
    }
}
