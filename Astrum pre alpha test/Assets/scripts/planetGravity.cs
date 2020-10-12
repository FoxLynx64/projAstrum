using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetGravity : MonoBehaviour
{

    public GameObject player;
    //sets up this gameobjects rigidbody
    public Rigidbody rb;

    public float magnification = 4;

    public int regUpdate = 1;
    public int farUpdate = 4;
    public int playerDist = 10;

    private int distUpdate = 0;
    private int physUpdate = 1;
    private int thisUpdate;


    void Start ()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        thisUpdate = farUpdate;

    }

    void FixedUpdate ()
    {

        if (distUpdate == 0)
        {

            if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) < playerDist)
            {

                thisUpdate = regUpdate;

            }
            else
            {

                thisUpdate = farUpdate;

            }

            distUpdate = 2;

        }
        else
        {

            distUpdate -= 1;

        }

        planetGravity[] attractors = FindObjectsOfType<planetGravity>();

        if (physUpdate == 0)
        {

            foreach (planetGravity attractor in attractors)
            {

                if (attractor != this)
                {

                  Attract(attractor);
                
                }
            
            }

            physUpdate = thisUpdate;

        }
        else
        {

            physUpdate -= 1;

        }


    }

    void Attract (planetGravity objToAttract)
    {
        //shows object we are attracting's rigidbody as a variable
        Rigidbody rbToAttract = objToAttract.rb;
        //gets the difference of the two gameobject
        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;
        //newtons law of universal gravitation
        float forceMagnitude = (rb.mass * rbToAttract.mass) / (distance * distance) * magnification * thisUpdate;
        Vector3 force = direction.normalized * forceMagnitude;
        //add a force to the rigidbody of the gameobject you want to attract simulating gravity
        rbToAttract.AddForce(force);

    }

}
