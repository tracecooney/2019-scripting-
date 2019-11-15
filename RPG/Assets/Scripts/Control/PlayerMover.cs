﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class PlayerMover : MonoBehaviour
    {
    	//This is a Udemy Tutorial
    	private void Update()
    	{
    		UpdateAnimator();
    	}
    
    	private void MoveToCursor()
    	{
    		print(Camera.main);
    		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    		RaycastHit hit;
    		bool hasHit = Physics.Raycast(ray, out hit);
    		if (hasHit)
    		{
    			MoveTo(hit.point);
    		}
    	}
    
    	public void MoveTo(Vector3 destination)
    	{
    		GetComponent<NavMeshAgent>().destination = destination;
    	}
    
    	private void UpdateAnimator()
         		{
         			Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
         			Vector3 localVelocity = transform.InverseTransformDirection(velocity);
         			float speed = localVelocity.z;
         			GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
         		}
    }

}
