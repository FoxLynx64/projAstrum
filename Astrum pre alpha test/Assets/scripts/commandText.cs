using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class commandText : MonoBehaviour
{

    public GameObject text;
    public GameObject text2;
    public GameObject text3;
    public GameObject texts;

    private GameObject textReal;

    public List<textcommand> texts1 = new List<textcommand>();


    void Start()
    {

        texts.Add(GameObject.FindWithTag("command").GetComponent<textcommand>());

    }

    public void OnFieldEnd(string textText)
    {

        text.SetActive(true);
        text2.SetActive(true);

        if (textText == "/notch")
        {
            
            textReal = Instantiate(text3, new Vector3(text3.transform.position.x, -167, 0), Quaternion.identity);
            textReal.GetComponent<Text>().text = "You Hath Been Smitten";
            textReal.transform.SetParent(texts.transform);
            textReal.GetComponent<Animator>().Play("text fade");
            texts1.Add(textReal.GetComponent<textcommand>());
            texts1.newScript.texts2.Add(textReal.GetComponent<textcommand>());

        }
        else if (textText == "/help")
        {

            //text.GetComponent<Text>().text = "/notch";
            text.GetComponent<Text>().text = "/makeitrain";
            text2.GetComponent<Text>().text = "/mintchip";
            text2.transform.position = new Vector3(text2.transform.position.x, -90, 
                text2.transform.position.z);
            text2.GetComponent<Animator>().Play("text fade");

        }
        else if (textText == "/makeitrain")
        {

            text.GetComponent<Text>().text = "Added " + 
                (1000 - GameObject.FindWithTag("Player").GetComponent<ShipStats>().energy).ToString()
                + " energy";
            GameObject.FindWithTag("Player").GetComponent<ShipStats>().energy = 1000;
             
        }
        else if (textText == "/mintchip")
        {

            text.GetComponent<Text>().text = "Added " +
                (1000 - GameObject.FindWithTag("Player").GetComponent<ShipStats>().health).ToString()
                + " health";
            GameObject.FindWithTag("Player").GetComponent<ShipStats>().health = 1000;

        }
        else
        {

            text.GetComponent<Text>().text= "Invalid Command";

        }

        text.GetComponent<Animator>().Play("text fade");

    }

}
