using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    public AudioSource music;

    float volume;

    private void Start()
    {
        volume = music.volume;
    }
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(music.volume > 0)
            {
                music.volume = 0;
            }
            else
            {
                music.volume = volume;
            }
        }	
	}
}
