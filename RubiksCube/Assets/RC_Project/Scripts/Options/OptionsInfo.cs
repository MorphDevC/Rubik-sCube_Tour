using System;
using System.Collections.Generic;
using UnityEngine;

public class OptionsInfo:MonoBehaviour
{
   

    private void Start()
    {
        var k = GetComponentsInChildren<ISliderInfo>();
        foreach (var m in k)
        {
            Debug.Log(m.GetTargetTag);
        }
    }
}
