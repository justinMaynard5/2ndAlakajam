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
                Debug.Log("Hit");
                if (hit.collider.CompareTag("Toggle"))
                {
                    Debug.Log("toggle");
                    hit.collider.GetComponent<Switch>().Toggle();
                }
            }
        }	
	}
}
