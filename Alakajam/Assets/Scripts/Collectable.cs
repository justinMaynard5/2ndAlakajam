using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Collectable : MonoBehaviour {

    public PlayableDirector play;
    public CollectedColors collected;
    public BlockColors color;
    public bool debugMode;

    private void Start()
    {
        collected.blue = false;
        collected.green = false;
        collected.red = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!debugMode)
            {
                switch (color)
                {
                    case BlockColors.Green:
                        collected.Green = true;
                        break;

                    case BlockColors.Red:
                        collected.Red = true;
                        break;

                    case BlockColors.Blue:
                        collected.Blue = true;
                        break;
                }

                play.Play();

                Destroy(gameObject, 8);
            }
            else if (debugMode)
            {
                Debug.Log("Debug");
                collected.Green = true;
                collected.Red = true;
                collected.Blue = true;
            }
        }
    }
}
