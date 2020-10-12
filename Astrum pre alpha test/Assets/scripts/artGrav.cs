using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artGrav : MonoBehaviour
{

    public float gravity = 1f;

    public GameObject gravDirec;

    public Rigidbody playerRigid;


    // Update is called once per frame
    void FixedUpdate()
    {

        playerRigid.AddForce(-gravDirec.transform.up * gravity);

    }
}
