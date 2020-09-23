using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoveEditor : MonoBehaviour
{

    public float sensitivity;

    private float HInput;
    private float HInputJ;
    private float VInput;
    private float VInputJ;


    // Use this for initialization
    void Start()
    {

        //sets the input up
        HInput = Input.GetAxis("Mouse X");
        HInputJ = Input.GetAxis("right joystick");
        VInput = Input.GetAxis("Mouse Y");
        VInputJ = Input.GetAxis("right joystick V");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("Q"))
        {

            //horizontal rotation
            this.gameObject.transform.Rotate(new Vector3(0, HInput * sensitivity * Time.deltaTime, 0), Space.World);
            this.gameObject.transform.Rotate(new Vector3(0, HInputJ * sensitivity * Time.deltaTime, 0), Space.World);

            //virtical rotation
            this.gameObject.transform.Rotate(new Vector3(-VInput * sensitivity * Time.deltaTime, 0, 0));
            this.gameObject.transform.Rotate(new Vector3(-VInputJ * sensitivity * Time.deltaTime, 0, 0));

        }

    }

}
