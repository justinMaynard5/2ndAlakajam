using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablingLigh : MonoBehaviour {

    public Disable[] blocks;
    public BlockColors color;
    public Light[] lights;

    int currentColor;
    bool playerInRange;

    private void Start()
    {
        foreach (Disable block in blocks)
        {
            block.visibleLayer.changedValue -= block.changedValue;
        }
        currentColor = 0;
        Switch();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            Switch();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false; 
        }
    }

    void Switch()
    {
        currentColor++;

        if(currentColor > System.Enum.GetValues(typeof(BlockColors)).Length -1)
        {
            currentColor = 0;
        }

        color = (BlockColors)currentColor;

        foreach(Light light in lights)
        {
            switch (color)
            {
                case BlockColors.Green:
                    light.color = Color.green;
                    break;

                case BlockColors.Red:
                    light.color = Color.red;
                    break;

                case BlockColors.Blue:
                    light.color = Color.blue;
                    break;
            }
        }

        foreach (Disable block in blocks)
        {
            block.Switch(block.color == color);
        }
    }
}
