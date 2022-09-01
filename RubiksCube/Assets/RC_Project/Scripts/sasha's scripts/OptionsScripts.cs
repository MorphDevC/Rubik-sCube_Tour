using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScripts : MonoBehaviour
{
    private bool _showOptions = true;
    public void PlayAnim()
    {
        if(_showOptions)
        {
            gameObject.GetComponent<Animator>().SetBool("OptionBool", true);
            _showOptions = false;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("OptionBool", false);
            _showOptions = true;
        }
    }
}
