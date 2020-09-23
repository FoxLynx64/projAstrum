using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;

    //shipstats script on the player
    public ShipStats script;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

    private float timestamp = 0f;
    public float shootrate;

    public bool trigreset;

    // Update is called once per frame
    void Update()
    {
        //shooting timed
        if (Time.time >= timestamp)
        {

            if (Input.GetButtonDown("Fire1"))
            {

                shoot(Bullet);

            }

            if (Input.GetAxis("left trigger") > 0 && trigreset == true)
            {

                shoot(Bullet);

                trigreset = false;

            }

            else if (Input.GetAxis("left trigger") == 0 && trigreset == false)
            {

                trigreset = true;

            }

        }

    }

    //shoot a bullet
    void shoot(GameObject bullet)
    {
        if (script.energy > 0)
        {

            float bulletshot = Time.time;

            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

            //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
            //Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            //set when you have reloaded
            timestamp = Time.time + shootrate;

            //remove energy in shipstats
            script.energy -= 1;

        }

    }

}