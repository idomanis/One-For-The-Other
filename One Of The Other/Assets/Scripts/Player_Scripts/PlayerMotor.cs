using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private PlayerInput pl;
    private PlayerInput.OnFootActions onFootAct;
    private CharacterController cc;
    private Vector3 playerVel;
    private bool isGrounded;
    private float gravity = -15f;

    [SerializeField]
    private float jumpHeight = 1.3f;

    [SerializeField]
    private float Speed = 5f;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Awake()
    {
        pl = new PlayerInput();
        onFootAct = pl.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = cc.isGrounded;
    }

    //Recive Inputs and apply them to the cc
    public void ProcessMovement(Vector2 input)
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = input.x;
        moveDir.z = input.y;
        cc.Move(transform.TransformDirection(moveDir) * Speed * Time.deltaTime);
        playerVel.y += gravity * Time.deltaTime;
        if (isGrounded && playerVel.y < 0) {playerVel.y = -5f;}
        cc.Move(playerVel * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVel.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }

    public void MovementSpeed(bool sneaking, bool sprinting)
    {
        if(isGrounded)
        {
            if (sneaking & sprinting) {Speed = 5;}
            else if (sneaking & !sprinting) {Speed = 2.5f;}
            else if (!sneaking & !sprinting) {Speed = 5;}
            else if (!sneaking & sprinting) {Speed = 10;}
        }
    }
}
