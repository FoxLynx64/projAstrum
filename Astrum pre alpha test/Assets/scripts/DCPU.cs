using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCPU : MonoBehaviour
{

    public GameObject instructions;
    public GameObject GUIScreen;
    public GameObject player;
    public GameObject ccamera;

    private bool onComputer = false;


    public void ExitDCPU()
    {

            instructions.SetActive(true);
            GUIScreen.SetActive(false);
            player.SetActive(true);
            ccamera.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            onComputer = false;

    }

    void OnTriggerStay(Collider col)
    {

        //if the gameobject inside the trigger collider is the FPSPlayer and 
        //they are not in the vehicle then do this
        if (col.gameObject.tag == "FPSPlayer" && onComputer == false)
        {
            player = col.gameObject;
            //turns on instructions to get inside the vehicle
            instructions.SetActive(true);
            //if you have completed the instructions (pressing e) then do this
            if (Input.GetButtonDown("Fire3"))
            {

                instructions.SetActive(false);
                GUIScreen.SetActive(true);
                player.SetActive(false);
                ccamera.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                onComputer = true;

            }

         }

     }
    void OnTriggerExit(Collider col)
    {
        //if that gameobject is the FPSPlayer then do this
        if (col.gameObject.tag == "FPSPlayer")
        {
            //removes instructions to get in vehicle from screen since it will not work
            instructions.SetActive(false);

        }

    }

}
