using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_S1 : Interactable
{
    [SerializeField] private GameObject IFKp;

    void Start()
    {
        IFKp.SetActive(false);
    }

    protected override void Interact()
    {
        IFKp.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
