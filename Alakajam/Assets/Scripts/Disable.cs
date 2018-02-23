using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour {

    public GlobalInt visibleLayer;
    public BlockColors color;
    public Collider col;
    public MeshRenderer mesh;

    // Use this for initialization
    void Awake ()
    {
        visibleLayer.changedValue += changedValue;	
	}

    void changedValue(int num)
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

    void Switch(bool isOn)
    {
        col.enabled = isOn;
        mesh.enabled = isOn;
    }
}
