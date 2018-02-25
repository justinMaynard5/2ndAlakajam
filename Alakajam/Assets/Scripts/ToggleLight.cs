using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

    public GameObject inactive;
    public GameObject active;
    public BlockColors color;
    public CollectedColors collectedColors;

	// Use this for initialization
	void Start ()
    {
        collectedColors.collected += Toggle;	
	}
	
	void Toggle (BlockColors inColor)
    {
        if(inColor == color)
        {
            inactive.SetActive(false);
            active.SetActive(true);
        }
    }

}
