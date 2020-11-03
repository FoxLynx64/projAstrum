using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSolarSystem : MonoBehaviour
{

    public GameObject energyCollectable;
    public GameObject healthCollectable;

    public nearestSystem script;
    public seed script2;

    public Vector3 chunkOnStart;

    public int range = 800;
    public int energyRatio = 50;
    public int healthRatio = 50;
    public int timesRan = 10;
    public int solarSystem;

    public GameObject newSys;

    private int energy;
    private int health;


    void Start()
    {

        while (script2.isRan == false)
        {
        }

        Debug.Log(script2.isRan.ToString());
        Debug.Log(script2.currentSeed.ToString());
        newSys = Instantiate(healthCollectable, new Vector3(0, 0, 0), Quaternion.identity);
        newSys.name = "solar system " + (timesRan + 1).ToString();
        script.systems.Add(newSys.GetComponent<system>());

        while (timesRan > 0)
        {

            populate(chunkOnStart);

            timesRan--;

        }

    }

    void populate(Vector3 chunk)
    {

        energy = Random.Range(0, 50) + energyRatio;
        health = Random.Range(0, 50) + healthRatio;

        if (energy > health)
        {

            Vector3 A = chunk + new Vector3(Random.Range(-range, range), Random.Range(-range, range),
                Random.Range(-range, range));

            newSys = Instantiate(healthCollectable, A, Quaternion.identity);
            newSys.name = "solar system" + timesRan.ToString();
            script.systems.Add(newSys.GetComponent<system>());

        }
        else
        {

            Vector3 A = chunk + new Vector3(Random.Range(-range, range), Random.Range(-range, range),
                Random.Range(-range, range));

            newSys = Instantiate(healthCollectable, A, Quaternion.identity);
            newSys.name = "solar system" + timesRan.ToString();
            script.systems.Add (newSys.GetComponent<system>());

        }

    }

}
