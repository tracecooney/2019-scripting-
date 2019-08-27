using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a Unity tutorial from Unitys Youtube Channel

public class ExampleBehaviourScript : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R));
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G));
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B));
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
