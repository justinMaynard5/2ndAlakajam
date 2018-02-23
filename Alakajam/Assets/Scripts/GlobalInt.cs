using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Int")]
public class GlobalInt : ScriptableObject {

    public int number;
    public System.Action<int> changedValue;

    public int Value
    {
        get
        {
            return number;
        }

        set
        {
            number = value;
            if (changedValue != null)
            {
                changedValue(number);
            }
        }
    }
}
