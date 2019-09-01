using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity Tutorial
public class DowhileLoop : MonoBehaviour {

	
	void Start ()
	{
		bool shouldContinue = false;

		do
		{
			print("Hello World");
		} 
		while (shouldContinue == true);
	}

}
