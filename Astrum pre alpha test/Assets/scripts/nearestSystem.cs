using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearestSystem : MonoBehaviour
{

    public KdTree<system> systems = new KdTree<system>();
    public KdTree<player> players = new KdTree<player>();

    public string nearestSolarSystem;

    public int optimizedUpdateFrames = 1;

    private int currentUpdateFrame;


    // Start is called before the first frame update
    void Start()
    {

        players.Add(GameObject.FindWithTag("Player").GetComponent<player>());

        findNearestSystem();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (currentUpdateFrame == 0)
        {

            findNearestSystem();

        }

        currentUpdateFrame -= 1;

    }

    void findNearestSystem()
    {

        systems.UpdatePositions();
        players.UpdatePositions();

        foreach (var player in players)
        {

            system nearestSolSys = systems.FindClosest(player.transform.position);

            Debug.DrawLine(player.transform.position, nearestSolSys.transform.position, Color.red);
            //Debug.Log(nearestSolSys.ToString());

            foreach (var system in systems)
            {

                system.Asteroids.SetActive(false);

            }

            nearestSolSys.Asteroids.SetActive(true);
            nearestSolSys.script1.enabled = true;
            nearestSolSys.script2.enabled = true;
            nearestSolarSystem = nearestSolSys.Ssystem.name;

        }

        currentUpdateFrame = optimizedUpdateFrames;

    }

}
