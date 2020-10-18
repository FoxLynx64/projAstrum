using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearestSystem : MonoBehaviour
{

    List<system> systems = new List<system>();
    List<player> players = new List<player>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //systems.UpdatePositions();

        //foreach (var player in players)
        //{

            //player nearestSolSys = systems.FindClosest(player.transform.position);

            //Debug.DrawLine(player.transform.position, nearestSolSys.transform.position, color.Red);

        //}

    }
}
