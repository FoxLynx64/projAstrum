using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintball : MonoBehaviour
{

    public float paintballdurability;
    public float timeDestory = 1f;

    // Use this for initialization
    void Start()
    {
        //destroy this object after 1 seconds to reduce lag
        Destroy(gameObject, timeDestory);

    }

    //when the bullet hits something
    void OnCollisionEnter(Collision collision)
    {

        //if the bullet hits the object fast enough it will do the following
        if (collision.relativeVelocity.magnitude > paintballdurability)
        {
        
            //variables of object hit 
            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            Transform t = collision.transform;

            //destroy this object with delay for previous to be executed
            Destroy(gameObject, 0.01f);

        }
    }
}
