using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private GameObject player;
    public int speed = 3;
    public Quaternion yrot;

    // private OptionalValueFloat _speed;
    // [SerializeField] private OptionsInfo OptionsInfoReference;
    // [SerializeField] private PropertyTag _propertyTag;


    

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(gameObject.name);
        player = (GameObject)this.gameObject;
        // if (OptionsInfoReference != null)
        //     _speed = new OptionalValueFloat(OptionsInfoReference.GetDefaultValue(_propertyTag));
        // else
        //     _speed = new OptionalValueFloat(3f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Rotate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Rotate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Rotate(Vector3.left * speed);
        }

    }

    public void RefreshCube()
    {
        player.transform.eulerAngles = new Vector3(0,315,0);
    }
    
}
