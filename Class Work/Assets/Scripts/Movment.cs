
using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movment : MonoBehaviour
{
	private Vector3 position;
	public CharacterController controller;
	public float speed = 1f;
	public float gravity = 3f;
	public float jumpSpeed = 10f;

	private int jumpCount = 2;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () 
	{
		//transform.Translate(position*Time.deltaTime);
		position.x = speed* Input.GetAxis("Horizontal");
		position.y -= gravity;

		if (!controller.isGrounded)
		{
			position.y -= gravity;
		}
		else
		{
			jumpCount = 2;
		}
		
		if (Input.GetButtonDown("Jump") && jumpCount > 0)
		{
			position.y = jumpSpeed;
			jumpCount--;
		}
		controller.Move(position*Time.deltaTime);
		//transform.Translate(position);
	}
	
}
