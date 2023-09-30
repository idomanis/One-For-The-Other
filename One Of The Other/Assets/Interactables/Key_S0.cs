using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_S0 : Interactable
{
    [SerializeField] private GameObject key;
    public bool HasKey = false;
    protected override void Interact()
    {
        HasKey = true;
        Destroy(this.gameObject);
    }
}
