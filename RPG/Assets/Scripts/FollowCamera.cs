using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour 
{
	//This is a Udemy Tutorial

	[SerializeField] private Transform target;
	void LateUpdate ()
	{
		transform.position = target.position;
	}
}
