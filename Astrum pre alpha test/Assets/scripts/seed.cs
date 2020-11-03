using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seed : MonoBehaviour
{

    public GameObject text;

    public int currentSeed;
    public int randSeed;

    public bool isRan = false;
    

    // Start is called before the first frame update
    void Start()
    {

        if(StaticVariables.randSeed == true)
        {

            string dateAndTime = System.DateTime.Now.ToString();
            dateAndTime = dateAndTime.Remove(0, 8);
            dateAndTime = dateAndTime.Replace(" ", "");
            dateAndTime = dateAndTime.Replace(":", "");
            dateAndTime = dateAndTime.Replace("PM", "");
            int.TryParse(dateAndTime, out randSeed);
            Debug.Log(randSeed);
            currentSeed = randSeed;

        }
        else
        {

            currentSeed = StaticVariables.seed;

        }
        Random.InitState(currentSeed);

        text.GetComponent<Text>().text = "Seed: " + currentSeed;

        isRan = true;

    }

}
