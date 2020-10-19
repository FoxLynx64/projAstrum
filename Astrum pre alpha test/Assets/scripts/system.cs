using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class system : MonoBehaviour
{

    public GameObject Ssystem;
    public GameObject Asteroids;

    public randompopulation script1;
    public randompopulation script2;


    public system(GameObject newSystem, GameObject newAsteroids, randompopulation newScript1, randompopulation newScript2)
    {

        Ssystem = newSystem;
        Asteroids = newAsteroids;
        script1 = newScript1;
        script2 = newScript2;

    }

}
