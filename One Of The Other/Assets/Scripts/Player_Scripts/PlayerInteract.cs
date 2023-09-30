using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Parts needed for Raycast
#1: Ray variable
    Origin
    direction
#2: RaycastHit variable
    hitinfo.distance
        .transform
        .rigidbody
        .collider
#3: Raycast() function
    checks for collisions*/
public class PlayerInteract : MonoBehaviour
{
    [SerializeField]
    private LayerMask mask;
    
    [SerializeField]
    private float distance = 2f;
    private Camera cam;

    private PlayerUI pui;

    private InputManager pi;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = GetComponent<PlayerLook>().cam;
        pui = GetComponent<PlayerUI>();
        pi = GetComponent<InputManager>();
    }

    void Update()
    {
        pui.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitinfo; //var to store hit collision info
        if(Physics.Raycast(ray, out hitinfo, distance, mask))
        {
            if(hitinfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactor = hitinfo.collider.GetComponent<Interactable>();
                pui.UpdateText(interactor.pMessage);
                if (pi.onFootAct.Interact.triggered)
                {
                    interactor.BaseInteract();
                }
            }
        }
    }
}
