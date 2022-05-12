using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool isLeft = animator.GetBool("isLeft");
        bool isRight = animator.GetBool("isRight");
        bool isBack = animator.GetBool("isBack");
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool backPressed = Input.GetKey("s");

        if (!isRunning && forwardPressed)
        {
            animator.SetBool("isRunning", true);
        }
        if(isRunning && !forwardPressed)
        {
            animator.SetBool("isRunning", false);
        }
        if (!isLeft && leftPressed)
        {
            animator.SetBool("isLeft", true);
        }
        if (isLeft && !leftPressed)
        {
            animator.SetBool("isLeft", false);
        }
        if (!isRight && rightPressed)
        {
            animator.SetBool("isRight", true);
        }
        if (isRight && !rightPressed)
        {
            animator.SetBool("isRight", false);
        }
        if (!isBack && backPressed)
        {
            animator.SetBool("isBack", true);
        }
        if (isBack && !backPressed)
        {
            animator.SetBool("isBack", false);
        }
    }
}
