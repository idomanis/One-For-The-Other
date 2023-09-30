using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NS_Key_MG1 : Interactable
{
    protected override void Interact()
    {
        SceneManager.LoadScene(1);
    }
}
