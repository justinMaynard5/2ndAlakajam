using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public System.Action<bool> Toggled;

    bool isOn;
    public Animator anim;

	public void Toggle()
    {
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

        if (anim != null)
        {
            anim.SetBool("on", isOn);
        }
    }
}
