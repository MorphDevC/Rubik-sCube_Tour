using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private GameObject player;
    public int speed = 3;
    public Quaternion yrot;


    

    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)this.gameObject;
        
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

    

    //Vector2 mouseLook;
    //Vector2 smoothV;
    //public float sensitivity = 5.0f;
    //public float smoothing = 2.0f;

    //GameObject charetcter;

    //private bool checking = false;

    //void Start()
    //{

    //    charetcter = this.transform.parent.gameObject;

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); // Take 2 axes

    //    md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
    //    // Multiply Axis X * Sens(5)*Smoothing(2)
    //    // The same with Axes Y
    //    // X & Y axes =[-1;1]

    //    smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
    //    smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
    //    mouseLook += smoothV;


    //        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
    //        charetcter.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, charetcter.transform.up);



    //}
}
