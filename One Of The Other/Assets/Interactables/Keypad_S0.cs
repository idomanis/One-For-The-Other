using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad_S0 : Interactable
{
    private Key_S0 keyscript;

    [SerializeField] private GameObject Door;

    private bool doorOpen = false;
    
    private void Start()
    {
        keyscript = GameObject.Find("Key").GetComponent<Key_S0>();
        if (keyscript == null)
        {
            Debug.LogError("Key or Key_S0 script is null");
        }

        else {keyscript.HasKey = false;}
    }

    //actually design the interactable's action
    protected override void Interact()
    {
        if (keyscript.HasKey == true)
        {
            doorOpen = !doorOpen;
            Door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
        }
    }
}
