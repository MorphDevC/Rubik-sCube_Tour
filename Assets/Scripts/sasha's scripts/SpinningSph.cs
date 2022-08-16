using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSph : MonoBehaviour
{
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Animator>().SetBool("SpinSph", true);
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Animator>().SetBool("SpinSph", false);
    }
}
