using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

    public GameObject inactive;
    public GameObject active;
    public BlockColors color;
    public CollectedColors collectedColors;
    public bool isMain;

	// Use this for initialization
	void Start ()
    {
        collectedColors.collected += Toggle;	
	}
	
	void Toggle (BlockColors inColor)
    {
        if (isMain)
        {
            Debug.Log(collectedColors.Green);
            Debug.Log(collectedColors.Red);
            Debug.Log(collectedColors.Blue);
            if (collectedColors.Green && collectedColors.Red && collectedColors.Blue)
            {
                inactive.SetActive(false);
                active.SetActive(true);
            }
        }
        else if(!isMain)
        {
            if (inColor == color)
            {
                inactive.SetActive(false);
                active.SetActive(true);
            }
        }
    }

}
