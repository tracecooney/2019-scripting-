using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DogClass : MonoBehaviour
{
    public UnityEvent badDogTurnOff;
    public UnityEvent dogUseParticle;

    private void OnMouseDown()
    {
        badDogTurnOff.Invoke();
        dogUseParticle.Invoke();
    }
    
}
