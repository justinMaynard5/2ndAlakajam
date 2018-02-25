using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealCursor : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
