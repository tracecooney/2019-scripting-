using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpThrough : MonoBehaviour
{
	public Collider platform;
	private void OnTriggerEnter(Collider other)
	{
		platform.enabled = false;
	}

	private void OnTriggerExit(Collider other)
	{
		platform.enabled = true;
	}
}
