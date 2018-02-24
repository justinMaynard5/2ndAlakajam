using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPlatform : MonoBehaviour {

    public Transform[] waypoints;
    public Switch toggel;

    bool isMoving;
    int currentWaypoint;

    private void Start()
    {
        toggel.Toggled += Toggle;
    }

    // Update is called once per frame
    void Update ()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, 0.1f);
            if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) <= 0.5f)
            {
                currentWaypoint++;
                if(currentWaypoint >= waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
        }	
	}

    void Toggle(bool isOn)
    {
        isMoving = isOn;
    }
}
