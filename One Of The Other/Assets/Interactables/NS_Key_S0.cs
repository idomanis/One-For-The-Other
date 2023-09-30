using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NS_Key_S0 : Interactable
{
    [SerializeField] private GameObject Gold_Key;

    protected override void Interact()
    {
        SceneManager.LoadScene(1);
        Destroy(Gold_Key);
    }
}
