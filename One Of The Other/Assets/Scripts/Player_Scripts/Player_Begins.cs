using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Begins : MonoBehaviour
{
    [SerializeField] private Text SText;
    private float WhenSTextAppears = 10f;
    private float WhenSTextDisappears;

    private void Start() 
    {
        SText.enabled = true;
        SText.text = "Use WASD or arrow keys for movement.\n\nHold Shift key to activate sprinting.\nRelease to stop.\n\nUse Space key to jump.\n\nUse ESC (escape) to quit the app.\n\nUse E key to use\\pick up objects.\n\nJump under the overhead and move.";
        WhenSTextDisappears = Time.time + WhenSTextAppears;
    }

    void Update()
    {
        if (SText.enabled == true && (Time.time >= WhenSTextDisappears)) {SText.enabled = false;}
    }
}
