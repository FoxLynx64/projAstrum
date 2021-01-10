using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class notGameManager : MonoBehaviour
{   

    public GameObject pauseMenu;
    public GameObject player;
    public GameObject playerGun;
    public GameObject ship;
    public GameObject ThirdPersonCam;
    public GameObject FirstPersonCam;
    public GameObject Gun1;
    public GameObject Gun2;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {

            if (pauseMenu.activeSelf == false)
            {

                pauseMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                playerGun.SetActive(false);
                player.GetComponent<RigidbodyFirstPersonController>().enabled = false;
                ship.GetComponent<playermovement>().enabled = false;
                if (ThirdPersonCam.activeSelf == true)
                {

                    ThirdPersonCam.GetComponent<CameraMovement>().enabled = false;

                }
                Gun1.GetComponent<shooting>().enabled = false;
                Gun2.GetComponent<shooting>().enabled = false;
                Time.timeScale = 0f;
                Debug.Log(Time.timeScale);

            }
            else
            {

                unpause();

            }

        }

    }

    public void unpause()
    {

        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerGun.SetActive(true);
        player.GetComponent<RigidbodyFirstPersonController>().enabled = true;

        if (ThirdPersonCam.activeSelf == true || FirstPersonCam.activeSelf == true)
        {

            ship.GetComponent<playermovement>().enabled = true;
            Gun1.GetComponent<shooting>().enabled = true;
            Gun2.GetComponent<shooting>().enabled = true;
        }

        ThirdPersonCam.GetComponent<CameraMovement>().enabled = true;
        Time.timeScale = 1f;

    }

}