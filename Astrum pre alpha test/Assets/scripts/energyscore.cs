using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyscore : MonoBehaviour
{

    public GameObject player;

    ShipStats script;


    void Start()
    {

        player = GameObject.FindWithTag("Player");
        script = player.GetComponent<ShipStats>();

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<Text>().text = "Energy: " + script.energy.ToString();

    }

}
