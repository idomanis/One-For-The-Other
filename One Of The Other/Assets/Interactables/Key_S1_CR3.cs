using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_S1_CR3 : Interactable
{
    [SerializeField] private GameObject shaft;
    [SerializeField] private GameObject hook;

    [HideInInspector]
    public bool HasCR3Key;

    void Start() => HasCR3Key = false;

    protected override void Interact()
    {
        HasCR3Key = true;
        Destroy(shaft);
        Destroy(hook);
        Destroy(this.gameObject);
    }
}
