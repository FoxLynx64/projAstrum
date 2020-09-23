using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompopulation : MonoBehaviour
{

    public GameObject energyCollectable;
    public GameObject healthCollectable;

    public int energyRatio = 50;
    public int healthRatio = 50;
    public int timesRan = 10;

    private int energy;
    private int health;


    void Start ()
    {

        while (timesRan > 0)
        {

            populate();

            timesRan--;

        }

    }

    void populate()
    {

        energy = Random.Range(0, 50) + energyRatio;
        health = Random.Range(0, 50) + healthRatio;

        if (energy > health)
        {

            Vector3 A = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));

            Instantiate(energyCollectable, A, Quaternion.identity);

        }
        else
        {

            Vector3 A = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));

            Instantiate(healthCollectable, A, Quaternion.identity);

        }
    
    }

}
