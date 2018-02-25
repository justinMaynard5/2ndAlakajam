using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public CollectedColors colors;
    public GlobalInt visible;

	public void RestartGame()
    {
        visible.changedValue = null;
        colors.collected = null;
        SceneManager.LoadScene("Level 1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
