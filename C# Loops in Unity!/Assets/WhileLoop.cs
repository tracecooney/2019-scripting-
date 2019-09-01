using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity Tutorial
public class WhileLoop : MonoBehaviour
{
	private int cupsInTheSink = 4;
	
	void Start () 
	{
		while (cupsInTheSink > 0)
		{
			Debug.Log("I have washed a cup!");
			cupsInTheSink--;
		}
	}
}
