using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwnAndUp : Interactable
{
    [SerializeField] private GameObject Door;

    private bool DownOrUp;

    void Start() => DownOrUp = false;
    protected override void Interact()
    {
        DownOrUp = !DownOrUp;
        Door.GetComponent<Animator>().SetBool("TrueOrFalse", DownOrUp);
    }
}
