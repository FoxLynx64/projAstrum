using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelscore : MonoBehaviour
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

        gameObject.GetComponent<Text>().text = "Level: " + script.level.ToString();

    }

}
