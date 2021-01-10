using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour
{

    static public int sensitivity;

    public GameObject A;
    CameraMovement script;

    static public int seed;

    static public bool randSeed = true;


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



    }

    public void newsensitivity(float newsensitivity)
    {

        sensitivity = (int) newsensitivity;
    
    }

    public void setSeed(string newSeed)
    {

        seed = int.Parse(newSeed);
        Debug.Log(seed.ToString());

    }

    public void randTog(bool Tog)
    {

        randSeed = Tog;
        Debug.Log(randSeed.ToString());

    }

}
