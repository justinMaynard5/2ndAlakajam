using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Collectable : MonoBehaviour {

    public PlayableDirector play;
    public CollectedColors collected;
    public BlockColors color;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
    }
}
