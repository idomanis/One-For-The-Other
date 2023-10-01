using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput pl;
    public PlayerInput.OnFootActions onFootAct;

    private PlayerMotor Motor;

    private PlayerLook look;

    private void Awake()
    {
        pl = new PlayerInput();
        onFootAct = pl.OnFoot;
        Motor = GetComponent<PlayerMotor>();
        onFootAct.Jump.performed += ctx => Motor.Jump();
        onFootAct.Sprint.started += ctx => Motor.MovementSpeed(false, true);
        onFootAct.Sprint.canceled += ctx => Motor.MovementSpeed(false, false);
        onFootAct.Sneak.started += ctx => Motor.MovementSpeed(true, false);
        onFootAct.Sneak.canceled += ctx => Motor.MovementSpeed(false, false);
        onFootAct.Leave.started += ctx => Application.Quit();
        look = GetComponent<PlayerLook>();
    }
    //processes movement from the input map of vector2
    void FixedUpdate() => Motor.ProcessMovement(onFootAct.Movement.ReadValue<Vector2>());

    private void LateUpdate() => look.ProcessLook(onFootAct.Look.ReadValue<Vector2>());

    private void OnEnable() => onFootAct.Enable();

    private void OnDisable() => onFootAct.Disable();
}
