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

    private bool split;
    private float newMass;


    void Start()
    {

        player = GameObject.FindWithTag("Player");
        script = player.GetComponent<ShipStats>();

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Bullet")
        {

            if (this.gameObject.GetComponent<Rigidbody>().mass <= 50)
            {

                if (split == false)
                {

                    Debug.Log("not split");

                    Debug.Log(this.gameObject.GetComponent<Rigidbody>().mass);

                    script.collected += 1;
                    script.energy += energyreward;

                    Destroy(this.gameObject);

                }
                else
                {

                    split = false;

                }

            }
            else if (this.gameObject.GetComponent<Rigidbody>().mass > 50)
            {

                Debug.Log("split");

                newMass = Mathf.Pow((((4 / 3) * Mathf.PI * 
                    Mathf.Pow((this.gameObject.GetComponent<Rigidbody>().mass / 2), 3))/2) / Mathf.PI / 
                    (4 / 3), 1f / 3f) * 2;
                this.gameObject.GetComponent<Rigidbody>().mass = newMass;
                this.gameObject.transform.localScale = new Vector3
                    (this.gameObject.GetComponent<Rigidbody>().mass, 
                    this.gameObject.GetComponent<Rigidbody>().mass, 
                    this.gameObject.GetComponent<Rigidbody>().mass);

                Instantiate(this.gameObject, new Vector3(this.gameObject.transform.position.x + 
                    (this.gameObject.GetComponent<Rigidbody>().mass * 1.5f), 
                    this.gameObject.transform.position.y + 
                    (this.gameObject.GetComponent<Rigidbody>().mass * 1.5f), 
                    this.gameObject.transform.position.z + 
                    (this.gameObject.GetComponent<Rigidbody>().mass * 1.5f)), 
                    Quaternion.identity);

                split = true;

            }

        }
        else if (col.gameObject.tag == "Player")
        {

            script.health -= healthpenalty;
            script.energy += badenergyreward;

            Destroy(this.gameObject);

        }
        else
        {



        }
        Debug.Log(col.gameObject);

    }

}
