using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBelow : MonoBehaviour
{

    public int textNumber;

    public List<textcommand> texts2 = new List<textcommand>();


    void Start()
    {

        texts2.Add(GameObject.FindWithTag("command").GetComponent<textcommand>());

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        foreach (var text in texts2)
        {

            if (text.gameObject == this.gameObject)
            {

                if (text.transform.position.y == this.gameObject.transform.position.y)
                {

                    this.transform.position = new Vector3(0, this.gameObject.transform.position.y + 70, 0);

                }

            }

        }

    }

}
