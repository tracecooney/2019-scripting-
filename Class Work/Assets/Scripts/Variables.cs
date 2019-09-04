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
	public string stringValue = "Bob11";
	public int firePower;
	public UnityEvent Event;

	//private void OnPlayerConnected();
	//{
		//Event.Invoke();
	//}

	//private void OnPlayerConnected(NetworkPlayer player)
	//{
		//Event.Invoke();
	//}

	private void OnTriggerEnter(Collider other)
	{
		//throw new NotImplementedException();
		Event.Invoke();
		//Event.Invoke(OnPlayerConnected(Destroy(gameObject.Player)));
	}

	//private void OnParticleTrigger()
	//{
		//Event.Invoke();
	//}
}
