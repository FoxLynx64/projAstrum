using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenSaver : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {

            Application.Quit();

        }
        
    }

}
