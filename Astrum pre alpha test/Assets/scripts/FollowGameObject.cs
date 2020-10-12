using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGameObject : MonoBehaviour
{

    public GameObject objectToFollow;


    // Update is called once per frame
    void Update()
    {

        this.gameObject.transform.position = objectToFollow.transform.position;
        this.gameObject.transform.rotation = objectToFollow.transform.rotation;

    }
}
