using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
    public UnityEvent turnOffLight;
    public UnityEvent explodeTheCat;

    private void OnMouseDown()
    {
        turnOffLight.Invoke();
        explodeTheCat.Invoke();
    }
}
