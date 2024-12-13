using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject menuParent;
    public KeyCode toggleKey = KeyCode.P;
    public bool hasBeenPaused = false;

    void Update()
    {
        if(Input.GetKeyDown(toggleKey))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if(!hasBeenPaused)
        {
            hasBeenPaused = true;
            Time.timeScale = 0.0f;
        }
        else
        {
            hasBeenPaused = false;
            Time.timeScale = 1.0f;
        }

        menuParent.SetActive(!menuParent.activeSelf);
    }
}
