using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent((typeof(NavMeshAgent)))]
public class AgentHandler : MonoBehaviour
{
	private NavMeshAgent agent;
	private Transform currentDestioation;
	public Transform destinationObj;
	private GameObject startObj;
	
	void Start ()
	{
		startObj = new GameObject();
		startObj.transform.position = transform.position;
		currentDestioation = transform;
		agent = GetComponent<NavMeshAgent>();
	}

	private void OnTriggerEnter(Collider other)
	{
		currentDestioation = destinationObj;
	}

	private void OnTriggerExit(Collider other)
	{
		currentDestioation = startObj.transform;
	}

	void Update ()
	{
		agent.destination = currentDestioation.position;
	}
}
