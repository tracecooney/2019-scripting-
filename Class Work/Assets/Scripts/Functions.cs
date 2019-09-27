using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
	public string playerName;
	private int myNumber;
	public float speed;
	public GameObject player;
	public Color playerColor = Color.yellow;
	
	void Start ()
	{
		myNumber = AddNumbers(10,5);
		ConFigGameObject();
	}

	private GameObject ConFigGameObject()
	{
		var newPlayer = Instantiate(player);
		newPlayer.layer = 0;
		newPlayer.active = true;
		newPlayer.tag = "Player";
		newPlayer. transform.position = Vector3.zero;
		newPlayer.name = playerName;
		newPlayer.GetComponent<Renderer>().material.color = playerColor;

		return player;
	}

	private int AddNumbers(int a, int b)
	{
		print("a + b");
		return a + b;
	}

	private string WelcomePlayer()
	{
		return playerName + "Welcome to the Game!";
	}

	private void OnTriggerEnter(Collider other)
	{
		speed = IncreaseSpeed(multiplier: 2f);
	}

	private float IncreaseSpeed(float multiplier)
	{
		return speed * multiplier;
	}
	
	void Update () 
	{
		
	}
}
