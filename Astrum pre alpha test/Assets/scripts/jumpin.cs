using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class jumpin : MonoBehaviour
{

    private bool inVehicle = false;

    public playermovement vehicleScript;
    public CameraMovement vehiclecamScript;
    public GameObject guiObj;
	public GameObject guiObj1;
    public GameObject player;
    public GameObject carcam;
	public GameObject playercam;
    public GameObject meshcoll;
    public GameObject gunone;
    public GameObject guntwo;
    public GameObject guide;
	public Transform playercampos;
    public Collider ship;


    //called on start
    void Start()
    {

        ship.enabled = false;
        //gets scripts that need to be enabled for vehicle to operate properly
        vehicleScript = GetComponent<playermovement>();
        //finds FPS player stuff


        //sets up camera position for FPS player
        playercampos.SetPositionAndRotation (playercam.transform.position, 
            playercam.transform.rotation);
        //sets vehicle camera to false
		carcam.SetActive(false);
        //turns off ui text instructions
        guiObj.SetActive(false);
		guiObj1.SetActive (false);
        gunone.GetComponent<shooting>().enabled = false;
        guntwo.GetComponent<shooting>().enabled = false;
        meshcoll.SetActive(true);
        guide.SetActive(false);

    }

    //is called when something enters and stays inside a trigger collider
    void OnTriggerStay(Collider other)
    {
        //if the gameobject inside the trigger collider is the FPSPlayer and 
        //they are not in the vehicle then do this
        if (other.gameObject.tag == "FPSPlayer" && inVehicle == false)
        {
            //turns on instructions to get inside the vehicle
            guiObj.SetActive(true);
            //if you have completed the instructions (pressing e) then do this
            if (Input.GetButtonDown("Fire3"))
            {
                //sets vehicle scripts to be active
                vehicleScript.enabled = true;
                //makes it so the player will spawn back were-ever the vehicle moves
                player.transform.parent = gameObject.transform;
				playercam.transform.parent = this.transform;
				playercam.transform.SetPositionAndRotation (this.transform.position, 
                    this.transform.rotation);
                //makes it so the main camera will not be the fpsplayer and the player 
                //will not move while in the vehicle
                player.SetActive(false);
                playercam.SetActive(false);
                //changes in vehicle to be true and activates vehicle camera
                inVehicle = true;
                carcam.SetActive(true);
                //sets ui instructions to whatever you have to do to get out and 
                //disables last set of instructions
                guiObj.SetActive(false);
				guiObj1.SetActive(true);
                gunone.GetComponent<shooting>().enabled = true;
                guntwo.GetComponent<shooting>().enabled = true;
                meshcoll.SetActive(false);
                ship.enabled = true;
                guide.SetActive(true);

            }
        }
    }
    //is called when something leaves the trigger collider
    void OnTriggerExit(Collider other)
    {
        //if that gameobject is the FPSPlayer then do this
        if (other.gameObject.tag == "FPSPlayer")
        {
            //removes instructions to get in vehicle from screen since it will not work
            guiObj.SetActive(false);

        }

    }

    //is called every frame
    void FixedUpdate()
    {
        //if you are in the vehicle and you press f then do this
        if (inVehicle == true && Input.GetKey(KeyCode.F))
        {

            ship.enabled = false;
            //disable the vehicle movement scripts so you 
            //dont move them while using the FPSPlayer
            vehicleScript.enabled = false;
            //un-parents the FPSPlayer and re-activates it
            player.SetActive(true);
            player.transform.parent = meshcoll.transform;
            //makes it so you are no longer in the vehicle and the vehicle camera is disabled
            inVehicle = false;
            carcam.SetActive(false);
            //FPSPlayer camera is set back to FPSPlayer position
			playercam.transform.parent = player.transform;
			playercam.transform.SetPositionAndRotation (playercampos.position, 
                playercampos.rotation);
            //disables instructions to get out of vehicles
			guiObj1.SetActive (false);
            gunone.GetComponent<shooting>().enabled = false;
            guntwo.GetComponent<shooting>().enabled = false;
            meshcoll.SetActive(true);
            guide.SetActive(false);
            playercam.SetActive(true);
            playercampos.GetComponent<Rigidbody>().velocity = this.gameObject.GetComponent<Rigidbody>().velocity;

        }

    }

}
