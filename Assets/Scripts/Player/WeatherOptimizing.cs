using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherOptimizing : MonoBehaviour
{

    public GameObject SnowArounHall=null;
    public GameObject SnowAroundTheDoor=null;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            
            SnowArounHall.SetActive(false);
            SnowAroundTheDoor.SetActive(true);
        }
    }
}
