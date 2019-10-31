using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponSwitch : MonoBehaviour 
{
    public enum States
    {
        Sword,
        Axe,
        Spear,
    }

    public States currentState;

    public UnityEvent OnSwordEvent, OnAxeEvent, OnSpearEvent;
    
    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.Sword:
                OnSwordEvent.Invoke();
                break;
            case States.Axe:
                OnAxeEvent.Invoke();
                break;
            case States.Spear:
                OnSpearEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }    
    }
}