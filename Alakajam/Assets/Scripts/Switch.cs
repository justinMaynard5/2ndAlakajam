using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public System.Action<bool> Toggled;

    bool isOn;

	public void Toggle()
    {
        Debug.Log("Toggled");
        if (isOn)
        {
            isOn = false;
            if(Toggled != null)
            {
                Toggled(false);
            }
        }
        else
        {
            isOn = true;
            if (Toggled != null)
            {
                Toggled(true);
            }
        }
    }
}
