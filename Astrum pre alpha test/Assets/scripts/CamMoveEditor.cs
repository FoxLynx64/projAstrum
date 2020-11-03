using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CamMoveEditor : MonoBehaviour
{

    public float Ssensitivity;
    public float z;

    public bool click;

    public GameObject ccamera;
    public GameObject realCamera;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {

            SceneManager.LoadScene("test 02");

        }

        if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {

            z = realCamera.transform.localPosition.z;
            if (z <= -1.5f && z >= -10)
            {

                realCamera.transform.localPosition = new Vector3(0, 0, Mathf.Min(Mathf.Max((z - (Input.GetAxis("Mouse ScrollWheel") * (z/2))), -10), -1.5f));

            }
            
        }
        if(click)
        {

        while (Input.GetAxis("Fire1") == 1)
        {

            //tells pivot gameobject to follow the center of the sphere/character
            ccamera.transform.position = this.gameObject.transform.position;

            //horizontal rotation
            ccamera.transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * Ssensitivity * Time.deltaTime, 0), Space.World);
            ccamera.transform.Rotate(new Vector3(0, Input.GetAxis("right joystick") * Ssensitivity * Time.deltaTime, 0), Space.World);

            Debug.Log(ccamera.transform.eulerAngles.x);

            //if(ccamera.transform.eulerAngles.x <= 45 || ccamera.transform.eulerAngles.x >= 315)
            //{

            //virtical rotation
            ccamera.transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * Ssensitivity * Time.deltaTime, 0, 0));
            ccamera.transform.Rotate(new Vector3(-Input.GetAxis("right joystick V") * Ssensitivity * Time.deltaTime, 0, 0));

            //}

        }

        }
       
    }

    public void rotate(bool theClick)
    {

        Debug.Log("is running now");

        click = theClick;
        click = false;

    }

}
