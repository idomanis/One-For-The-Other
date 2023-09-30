using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad_CR2 : Interactable
{
    [SerializeField] private GameObject IFKpCR2;

    void Start() => IFKpCR2.SetActive(false);
    protected override void Interact()
    {
        IFKpCR2.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
