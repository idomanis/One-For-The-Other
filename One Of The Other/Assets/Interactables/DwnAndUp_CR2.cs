using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwnAndUp_CR2 : Interactable
{
    private Key_S1_CR1 key;
    [SerializeField] private GameObject GateCR2;

    private bool DownOrUp;

    void Start()
    {
        DownOrUp = false;
        key = GameObject.Find("Handle").GetComponent<Key_S1_CR1>();
        if(key == null) {Debug.LogError("GameObject \"Handle\" or script \"Key_S1_CR1\" is missing");}
    }

    protected override void Interact()
    {
        if (key.HasCR1Key == true)
        {
            DownOrUp = !DownOrUp;
            GateCR2.GetComponent<Animator>().SetBool("UpOrDownBool", DownOrUp);
        }
    }
}
