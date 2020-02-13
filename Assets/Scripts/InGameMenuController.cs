using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuController : MonoBehaviour
{
    public Canvas myMenuCanvas;

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            myMenuCanvas.enabled = !myMenuCanvas.enabled;

            if (myMenuCanvas.enabled == true)
            {
                Cursor.lockState = CursorLockMode.Confined; // UnLock the cursor
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked; // UnLock the cursor
                Cursor.visible = false;
            }
        }
    }
}
