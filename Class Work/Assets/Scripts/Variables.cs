using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

public class Variables : MonoBehaviour
{

	public float floatValue = 5f;
	public int intValue = 20;
	public string stringValue = "Bob!!";
	public int firePower;
	public UnityEvent Event;
	public int applyDamage = 10;
	
	private void OnTriggerEnter(Collider other)
	{

		print("Test");
		Event.Invoke();
		
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!enabled) return;
		print("Test 2");
		Event.Invoke();
	}
	
}
