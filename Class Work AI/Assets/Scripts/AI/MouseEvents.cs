using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour
{
	private Camera cam;
	public Vector3Data data;

	private void Start()
	{
		cam = Camera.main;
	}

	private void OnMouseDown()
	{
		Debug.Log("cam.ScreenToWorldPoint");
		var raycast = cam.ScreenPointToRay(Input.mousePosition);
		var hit = raycast.GetPoint(distance: 10);
		Debug.Log(hit);
	}
}
