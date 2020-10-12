using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeMultiplier : MonoBehaviour
{

    public float timeMult;
    
    public GameObject txt;


    // Update is called once per frame
    void Update()
    {

        Time.timeScale = timeMult;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;

    }

}
