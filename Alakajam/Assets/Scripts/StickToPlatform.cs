using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour {

    Transform platform;
    Vector3 lastPosition;
	
	// Update is called once per frame
	void Update ()
    {
	    if(platform != null)
        {
            if(lastPosition != Vector3.zero)
            {
                transform.position += platform.position - lastPosition;
            }
            lastPosition = platform.position;
        }	
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Platform"))
        {
            platform = collision.transform;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Platform"))
        {
            platform = null;
            lastPosition = Vector3.zero;
        }
    }
}
