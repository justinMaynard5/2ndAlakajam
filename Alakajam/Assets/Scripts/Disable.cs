using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour {

    public GlobalInt visibleLayer;
    public BlockColors color;
    public Collider col;
    public MeshRenderer mesh;
    public Rigidbody rb;
    public MonoBehaviour[] scripts;

    // Use this for initialization
    void Awake ()
    {
        visibleLayer.changedValue += changedValue;	
	}

    public void changedValue(int num)
    {
        if((int)color == num)
        {
            Switch(true);
        }
        else
        {
            Switch(false);
        }
    }

    public void Switch(bool isOn)
    {
        col.enabled = isOn;
        mesh.enabled = isOn;

        if (rb != null)
        {
            rb.useGravity = isOn;
            rb.isKinematic = !isOn;
        }
            
        if (scripts != null)
        {
            foreach (MonoBehaviour script in scripts)
            {
                script.enabled = isOn;
            }
        }
    }
}
