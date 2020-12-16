using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commandText : MonoBehaviour
{

    public nearestSystem script;

    public GameObject text;
    public GameObject text2;
    public GameObject text3;
    public GameObject texts;

    public GameObject textReal;

    public List<textcommand> texts1 = new List<textcommand>();


    void Start()
    {

        //texts1.Add(GameObject.FindWithTag("command").GetComponent<textcommand>());

    }

    public void OnFieldEnd(string textText)
    {

        text.SetActive(true);
        text2.SetActive(true);

        if (textText == "/notch")
        {
            
            textReal = Instantiate(text3, new Vector3(text3.transform.position.x, 10, text3.transform.position.z), Quaternion.identity);
            textReal.GetComponent<Text>().text = "You Hath Been Smitten";
            textReal.transform.SetParent(texts.transform);
            textReal.transform.position = new Vector3(text3.transform.position.x, 10, text3.transform.position.z);
            textReal.GetComponent<Animator>().Play("text fade");
            //texts1.Add(textReal.GetComponent<textcommand>());
            //texts1.newScript.texts2.Add(textReal.GetComponent<textcommand>());

        }
        else if (textText == "/help")
        {

            //text.GetComponent<Text>().text = "/notch";
            text.GetComponent<Text>().text = "/makeitrain";
            text2.GetComponent<Text>().text = "/closestsolarsystem";
            text2.transform.localPosition = new Vector3(text.transform.position.x, -130,
                text.transform.position.z);
            text2.transform.localPosition = new Vector3(text2.transform.position.x, -160, 
                text2.transform.position.z);
            text2.GetComponent<Animator>().Play("text fade");
            text.GetComponent<Animator>().Play("text fade");

        }
        else if (textText == "/makeitrain")
        {

            text.GetComponent<Text>().text = "Added " + 
                (1000 - GameObject.FindWithTag("Player").GetComponent<ShipStats>().energy).ToString()
                + " energy";
            GameObject.FindWithTag("Player").GetComponent<ShipStats>().energy = 1000;
            text.GetComponent<Animator>().Play("text fade");

        }
        else if (textText == "/mintchip")
        {

            text.GetComponent<Text>().text = "Added " +
                (1000 - GameObject.FindWithTag("Player").GetComponent<ShipStats>().health).ToString()
                + " health";
            GameObject.FindWithTag("Player").GetComponent<ShipStats>().health = 1000;
            text.GetComponent<Animator>().Play("text fade");

        }
        else if (textText == "/closestsolarsystem")
        {

            text.GetComponent<Text>().text = script.nearestSolarSystem;
            Debug.Log(script.nearestSolarSystem);
            text.GetComponent<Animator>().Play("text fade");

        }
        else
        {

            text.GetComponent<Text>().text= "Invalid Command";
            text.GetComponent<Animator>().Play("text fade");

        }



    }

}
