using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Collect Colors")]
public class CollectedColors : ScriptableObject {

    public bool green;
    public bool red;
    public bool blue;
    public System.Action<BlockColors> collected;

    public bool Green
    {
        get
        {
            return green;
        }
        set
        {
            green = value;
            if(collected != null)
            {
                collected(BlockColors.Green);
            }
        }
    }

    public bool Red
    {
        get
        {
            return red;
        }
        set
        {
            red = value;
            if (collected != null)
            {
                collected(BlockColors.Red);
            }
        }
    }

    public bool Blue
    {
        get
        {
            return blue;
        }
        set
        {
            blue = value;
            if (collected != null)
            {
                collected(BlockColors.Blue);
            }
        }
    }
}
