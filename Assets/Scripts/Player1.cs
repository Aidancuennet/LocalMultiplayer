using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Rigidbody2D body;
    [SerializeField] private PlayerFoot foot;

    private const float DeadZone = 0.1f;
    private const float MoveSpeed = 5.0f;
    private const float JumpSpeed = 10.0f;

    private bool facingRight_ = true;
    private bool jumpButtonDown_ = false;

    void Start()
    {
        //  ChangeState(State.Jump);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpButtonDown_ = true;
        }
    }

    void FixedUpdate()
    {
        float moveDir = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir -= 1.0f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDir += 1.0f;
        }

         if (foot.FootContact > 0 && jumpButtonDown_)
          {
             Jump();
          }
           jumpButtonDown_ = false;

        var vel = body.velocity;
        body.velocity = new Vector2(MoveSpeed * moveDir, vel.y);
    }
    private void Jump()
    {
        var vel = body.velocity;
        body.velocity = new Vector2(vel.x, JumpSpeed);
    }
}