using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Brackeys Tutorial

public class PlayerController : MonoBehaviour {

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    private object fasle;


    // Update is called once per frame
    void Update ()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
	}

    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, fasle, fasle);
    }
}
