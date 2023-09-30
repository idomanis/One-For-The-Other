using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_S1_CR1 : Interactable
{
    [SerializeField] private GameObject shaft;
    [SerializeField] private GameObject hook;

    [HideInInspector]
    public bool HasCR1Key;
    
    void Start() => HasCR1Key = false;

    protected override void Interact()
    {
        HasCR1Key = true;
        Destroy(shaft);
        Destroy(hook);
        Destroy(this.gameObject);
    }
}
