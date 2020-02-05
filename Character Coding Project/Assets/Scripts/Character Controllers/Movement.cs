using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    public Vector3 position;
    public CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, JumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;

    Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        

        if (controller.isGrounded)
        {
           
            jumpCount = 0;
            if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
            {
                velocity.y = JumpSpeed * gravity * Time.deltaTime;
                position.y = velocity.y;
                jumpCount++;
                Debug.Log("Grounded");
            }
        }
       
        position.Set(Input.GetAxis("Horizontal") * moveSpeed, 0, Input.GetAxis("Vertical") * moveSpeed);

        position.y -= gravity * Time.deltaTime;

        controller.Move(position * Time.deltaTime);
        
    }
}

