using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleView : MonoBehaviour {

    public GlobalInt visibleLayer;
    public AudioSource sfx;
    public AudioClip[] clips;

    private void Start()
    {
        visibleLayer.Value = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            visibleLayer.Value = 0;
            sfx.PlayOneShot(clips[0]);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            visibleLayer.Value = 1;
            sfx.PlayOneShot(clips[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            visibleLayer.Value = 2;
            sfx.PlayOneShot(clips[2]);
        }
    }
}

public enum BlockColors { Green, Red, Blue };
