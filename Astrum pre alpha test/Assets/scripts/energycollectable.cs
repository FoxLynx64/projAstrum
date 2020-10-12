using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energycollectable : MonoBehaviour
{

    public GameObject player;

    ShipStats script;

    public int energyreward = 1;
    public int badenergyreward = 1;
    public int healthpenalty = 1;


    void Start()
    {

        player = GameObject.FindWithTag("Player");
        script = player.GetComponent<ShipStats>();

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Bullet")
        {

            script.collected += 1;
            script.energy += energyreward;

            Destroy(this.gameObject);

        }
        else if (col.gameObject.tag == "Player")
        {

            script.health -= healthpenalty;
            script.energy += badenergyreward;

            Destroy(this.gameObject);

        }

    }

}
