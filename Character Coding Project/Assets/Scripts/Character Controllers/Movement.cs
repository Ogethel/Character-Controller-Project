using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    public Vector3 position;
    private CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, JumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = JumpSpeed;
            jumpCount++;
        }

        controller.Move(position * Time.deltaTime);
    }
}

