
using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
	public UnityEvent triggerEvent;
	private void OnTriggerEnter(Collider other)
	{
		print("Test 3");
		triggerEvent.Invoke();
	}
}
