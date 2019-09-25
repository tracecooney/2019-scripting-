using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatments : MonoBehaviour
{
	public int a = 4;
	public int b = 5;
	public int c = 10;
	public string password = "Ou812";
	public bool lightsOn = true;
	
	
	void Start () 
	{
		
		//if (a + b = c)
		{
			print("true");
		}
		//else
		{
			print("false");
		}

		if (password == "OU812") 
		{
			print("true");
		}

		if (lightsOn)
		{
			print("true");
		}
	}
	
	
}
