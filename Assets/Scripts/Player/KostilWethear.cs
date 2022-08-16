using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KostilWethear : MonoBehaviour
{
    public ParticleSystem Snow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Snow.Clear();
            Snow.Pause();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
