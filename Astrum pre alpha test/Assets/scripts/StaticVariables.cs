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

        script = A.GetComponent<CameraMovement>();
        script.Ssensitivity = sensitivity;

    }

    public void newsensitivity(float newsensitivity)
    {

        sensitivity = (int) newsensitivity;
        Debug.Log(sensitivity);

    }

}
