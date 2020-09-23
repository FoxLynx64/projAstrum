using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthcollect : MonoBehaviour
{

    public GameObject player;

    ShipStats script;

    public int healthreward = 1;
    public int healthpenalty = 1;


    void Start()
    {

        player = GameObject.FindWithTag("Player");
        script = player.GetComponent<ShipStats>();

    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Bullet")
        {

            script.collected += 1;
            script.health += healthreward;

            Destroy(this.gameObject);

        }
        else if (col.gameObject.tag == "Player")
        {

            script.health -= healthpenalty;

            Destroy(this.gameObject);

        }

    }

}
