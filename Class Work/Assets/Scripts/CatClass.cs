using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{

    public UnityEvent turnOffLight;
    public UnityEvent explodeTheCat;

    public void OnTriggerEnter(Collider other)
    {
        turnOffLight.Invoke();
        explodeTheCat.Invoke();
    }
}
