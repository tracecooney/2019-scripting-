using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ENUMSwitch : MonoBehaviour 
{
	public enum States
	{
		Start,
		Playtime,
		End,
	}

	public States currentStates;

	public UnityEvent OnStartEvent, OnPlayerEvent, OnEndEvent;

	private void Update()
	{
		switch (currentStates)
		{
			case States.Start:
				OnStartEvent.Invoke();
				break;
			case States.Playtime:
				OnPlayerEvent.Invoke();
				break;
			case States.End:
				OnEndEvent.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
