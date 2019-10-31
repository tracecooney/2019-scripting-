using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{
	//This is a Udemy Tutorial
	[SerializeField]
	private Transform target;
	private void Update ()
	{
		GetComponent<NavMeshAgent>().destination = target.position;
	}
}
