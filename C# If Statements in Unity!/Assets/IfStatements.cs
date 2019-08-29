using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;

//this is a Unity tutorial
public class IfStatements : MonoBehaviour
{
	public float coffeeTemperature = 85.0f;
	public float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;

	void Update ()
	{
		if (Input.GetButtonDown(KeyCode.Space.ToString()))
			TemperatureTest();
		coffeeTemperature -= Time.deltaTime * 5f;
	}

	void TemperatureTest()
	{
		if (coffeeTemperature > hotLimitTemperature)
		{
			print("Coffee is too hot.");
		}
		else if (coffeeTemperature < coldLimitTemperature)
		{
			print("Coffee is too cold.");
		}
		else
		{
			print("Coffee is just right.");
		}
	}
}
