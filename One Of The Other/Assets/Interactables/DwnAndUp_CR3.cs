using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwnAndUp_CR3 : Interactable
{
    private Key_S1_CR3 key;
    [SerializeField] private GameObject GateCR3;

    private bool DownOrUp;

    void Start()
    {
        DownOrUp = false;
        key = GameObject.Find("HandleCR3").GetComponent<Key_S1_CR3>();
        if(key == null) {Debug.LogError("GameObject \"HandleCR3\" or script \"Key_S1_CR3\" is missing");}
    }

    protected override void Interact()
    {
        if (key.HasCR3Key == true)
        {
            DownOrUp = !DownOrUp;
            GateCR3.GetComponent<Animator>().SetBool("UpDownBool", DownOrUp);
        }
    }
}
