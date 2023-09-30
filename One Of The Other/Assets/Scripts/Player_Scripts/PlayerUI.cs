using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private Text promptText;
    
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
