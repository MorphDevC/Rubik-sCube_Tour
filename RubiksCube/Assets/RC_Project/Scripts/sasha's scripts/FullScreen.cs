using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{

    public void Fullscreen(bool is_fullscreen)
    {
        Screen.fullScreen = is_fullscreen;
    }
}
