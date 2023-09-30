using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NS_InputForKeypad_S1 : MonoBehaviour
{
    [SerializeField] private InputField IF;
    [SerializeField] private GameObject InputFieldGO;
    [SerializeField] private GameObject EnterButton;
    private bool DoorOpen;

    [SerializeField] private GameObject Door;

    void Start()
    {
        DoorOpen = false;
    }

    public void ReadUserInput()
    {
        if(IF.text == "102114101101") 
        {
            DoorOpen = !DoorOpen;
            Door.GetComponent<Animator>().SetBool("InputIsCorrect", DoorOpen);
            InputFieldGO.SetActive(false);
            EnterButton.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            InputFieldGO.SetActive(false);
            EnterButton.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
