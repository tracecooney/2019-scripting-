﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruit : MonoBehaviour
{
	public bool appleIsRipe, orangeIsRipe, peachIsRipe;

	void Start()
	{
		if (appleIsRipe)
		{
			print("Go pick the Apple!");
		}
		else if (orangeIsRipe)
		{
			 print("Go pick the Orange!");
		}
		else if (peachIsRipe)
		{
			print("Go pick the Peach");
		}
		else
		{
			print("Nothing is Ripe.");
		}
	}
		

}
