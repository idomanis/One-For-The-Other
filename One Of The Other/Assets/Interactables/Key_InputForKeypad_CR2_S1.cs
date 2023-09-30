using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_InputForKeypad_CR2_S1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputField IF;
    [SerializeField] private GameObject InputFieldGO;
    [SerializeField] private GameObject EnterButton;
    private bool Keydown;

    [SerializeField] private GameObject Key;

    void Start()
    {
        Keydown = false;
    }

    public void ReadUserInput()
    {
        if (IF.text == "114")
        {
            Keydown = true; Key.GetComponent<Animator>().SetBool("InputIsGood", Keydown);
            InputFieldGO.SetActive(false);
            EnterButton.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
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
