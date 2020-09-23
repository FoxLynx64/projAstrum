using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{

    public int health = 10;
    public int energy = 10;
    public int collected = 0;
    public int level = 1;

    // Update is called once per frame
    void Update()
    {
        
        if (collected > 9)
        {

            level = 2;

        }

        if (health <= 0)
        {



        }

    }

}
