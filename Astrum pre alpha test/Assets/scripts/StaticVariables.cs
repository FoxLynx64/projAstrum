using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour
{

    static public int sensitivity;

    public GameObject A;
    CameraMovement script;


    void Start ()
    {

        if(sensitivity == 0)
        {

            sensitivity = 500;

        }

        script = A.GetComponent<CameraMovement>();
        script.Ssensitivity = sensitivity;

    }

    void Update ()
    {

        if (Input.GetKey("escape"))
        {

            Application.Quit();

        }

    }

    public void newsensitivity(float newsensitivity)
    {

        sensitivity = (int) newsensitivity;
    
    }

}
