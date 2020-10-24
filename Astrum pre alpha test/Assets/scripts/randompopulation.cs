using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompopulation : MonoBehaviour
{

    public GameObject energyCollectable;
    public GameObject healthCollectable;

    public Vector3 chunkOnStart;

    public int range = 800;
    public int energyRatio = 50;
    public int healthRatio = 50;
    public int timesRan = 10;

    private GameObject newAst;

    private string astString;

    private int energy;
    private int health;


    void Start ()
    {

        astString = this.gameObject.name + "/" + "Asteroids";
        Debug.Log(astString);

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

            Vector3 A = this.gameObject.transform.position + chunk + new Vector3(Random.Range(-range, range), Random.Range(-range, range), 
                Random.Range(-range, range));

            newAst = Instantiate(energyCollectable, A, Quaternion.identity) as GameObject;
            newAst.transform.parent = GameObject.Find(astString).transform;
            newAst.name = this.gameObject.name + " " + "E Asteroid" + timesRan.ToString();

        }
        else
        {

            Vector3 A = this.gameObject.transform.position + chunk + new Vector3(Random.Range(-range, range), Random.Range(-range, range),
                Random.Range(-range, range));

            newAst = Instantiate(healthCollectable, A, Quaternion.identity) as GameObject;
            newAst.transform.parent = GameObject.Find(astString).transform;
            newAst.name = this.gameObject.name + " " + "H Asteroid" + timesRan.ToString();

        }
    
    }

}
