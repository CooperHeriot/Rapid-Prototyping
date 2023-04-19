using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;
    public bool Paused;

    public bool lockCursor, LC;
    // Start is called before the first frame update
    void Start()
    {
        LC = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Paused == true)
        {
            Time.timeScale = 0;
            PausePanel.SetActive(true);
        } else
        {
            Time.timeScale = 1;
            PausePanel.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Paused = !Paused;
        }
        if (LC == false)
        {
            if (lockCursor == true && Paused == false)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }
        
    }

    public void PauseTogggle()
    {
        Paused = !Paused;
    }
}
