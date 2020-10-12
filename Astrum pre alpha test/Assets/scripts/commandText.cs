using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commandText : MonoBehaviour
{

    public GameObject text;


    public void OnFieldEnd(string textText)
    {

        text.SetActive(true);

        if (textText == "/notch")
        {

            text.GetComponent<Text>().text = "You Hath Been Smitten";

        }
        else if (textText == "/help")
        {

            text.GetComponent<Text>().text = "/notch";

        }
        else
        {

            text.GetComponent<Text>().text= "Invalid Command";

        }

        text.GetComponent<Animator>().Play("text fade");

    }

}
