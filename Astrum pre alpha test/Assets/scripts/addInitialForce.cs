using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addInitialForce : MonoBehaviour
{

    public float startingVelocity;


    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * startingVelocity);
        

    }

}
