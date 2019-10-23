
using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class TriggerEvents : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent triggerEvent;
	private void OnTriggerEnter(Collider other)
	{
		print("Test 3");
		triggerEvent.Invoke();
	}
}
