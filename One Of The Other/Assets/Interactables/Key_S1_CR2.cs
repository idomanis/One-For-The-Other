using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_S1_CR2 : Interactable
{
    [SerializeField] private GameObject shaft;
    [SerializeField] private GameObject hook;

    [HideInInspector]
    public bool HasCR2Key;

    void Start() => HasCR2Key = false;

    protected override void Interact()
    {
        HasCR2Key = true;
        Destroy(shaft);
        Destroy(hook);
        Destroy(this.gameObject);
    }
}
