using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPlatform : MonoBehaviour {

    public Transform[] waypoints;
    public Switch toggel;

    bool isMoving;
    public bool noSwitch;
    int currentWaypoint;

    private void Start()
    {
        if (toggel != null && !noSwitch)
        {
            toggel.Toggled += Toggle;
        }

        if (noSwitch)
        {
            isMoving = true;
        }
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
        Debug.Log("Start Move");
        isMoving = isOn;
    }
}
