using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //message displayed when looking at interactable
    public string pMessage;

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact() {}
}
