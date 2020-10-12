using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float Ssensitivity;

    public GameObject ccamera;

	
	// Update is called once per frame
	void Update ()
    {

        //tells pivot gameobject to follow the center of the sphere/character
        ccamera.transform.position = this.gameObject.transform.position;

        //horizontal rotation
        ccamera.transform.Rotate (new Vector3(0, Input.GetAxis("Mouse X") * Ssensitivity * Time.deltaTime, 0), Space.Self);
        ccamera.transform.Rotate (new Vector3(0, Input.GetAxis("right joystick") * Ssensitivity * Time.deltaTime, 0), Space.Self);

        //virtical rotation
        ccamera.transform.Rotate (new Vector3(-Input.GetAxis("Mouse Y") * Ssensitivity * Time.deltaTime, 0, 0), Space.Self);
        ccamera.transform.Rotate (new Vector3(-Input.GetAxis("right joystick V") * Ssensitivity * Time.deltaTime, 0, 0), Space.Self);

    }

}
