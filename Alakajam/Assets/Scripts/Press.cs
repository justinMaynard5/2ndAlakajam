using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                if (hit.collider.CompareTag("Toggle"))
                {
                    hit.collider.GetComponent<Switch>().Toggle();
                }
            }
        }	
	}
}
