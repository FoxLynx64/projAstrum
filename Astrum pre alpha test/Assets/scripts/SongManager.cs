using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{

    seed script;

    public GameObject GameManager;
    
    public GameObject Song1;
    public GameObject Song2;
    public GameObject Song3;
    public GameObject Song4;

    public int time = 0;
    public int maxTime = 1000000;
    public int minTime = 100000;


    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (GameManager.GetComponent<seed>().isRan == true && time == 0)
        {

            int randNum = Random.Range(1, 5);

            if(randNum == 1)
            {

                Song1.GetComponent<AudioSource>().Play();

            }
            else if (randNum == 2)
            {

                Song2.GetComponent<AudioSource>().Play();

            }
            else if (randNum == 3)
            {

                Song3.GetComponent<AudioSource>().Play();

            }
            else
            {

                Song4.GetComponent<AudioSource>().Play();

            }

            time = Random.Range(minTime, maxTime);

        }

        time -= 1;

    }
}
