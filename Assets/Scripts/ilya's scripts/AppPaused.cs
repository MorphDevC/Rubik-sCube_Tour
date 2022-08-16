using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppPaused : MonoBehaviour
{
    bool isPaused = false;

    //void OnGUI()
    //{
    //    if (isPaused)
    //    {
    //        GUI.Label(new Rect(100, 100, 50, 30), "Game paused");
    //        AudioListener.volume = 0;
    //    }
    //}

    void OnApplicationFocus(bool hasFocus)
    {
        isPaused = !hasFocus;
        //AudioListener.volume = 1;
    }

    void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
    }
}