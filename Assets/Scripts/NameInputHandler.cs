using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using TMPro; 

public class NameInputHandler : MonoBehaviour
{
    public DialogueRunner dialogueRunner; 
    public TMP_InputField inputField;     
    public GameObject inputFieldObject;  

    [YarnCommand("input")]
    public void TriggerNameInput()
    {
        inputFieldObject.SetActive(true);

        inputField.Select();
        inputField.ActivateInputField();
    }

    public void OnInputSubmit()
    {
        string playerName = inputField.text;

        dialogueRunner.VariableStorage.SetValue("$player_name", playerName);

        inputFieldObject.SetActive(false);

        inputField.text = "";

        dialogueRunner.DialogueComplete();
    }
}

