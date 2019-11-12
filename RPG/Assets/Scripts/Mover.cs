using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour 
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
    }

    private void MoveToCursor()
    {
        print(Camera.main);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            GetComponent<PlayerMover>().MoveTo(hit.point);
            
        }
    }
}
