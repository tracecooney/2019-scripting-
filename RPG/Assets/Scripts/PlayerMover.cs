using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMover : MonoBehaviour
{
	//This is a Udemy Tutorial
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			MoveToCursor();
		}
	}

	private void MoveToCursor()
	{
		print(Camera.main);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		bool hasHit = Physics.Raycast(ray, out hit);
		if (hasHit)
		{
			GetComponent<NavMeshAgent>().destination = hit.point;
		}
	}
}
