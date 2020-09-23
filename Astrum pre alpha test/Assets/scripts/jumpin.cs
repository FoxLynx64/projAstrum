using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class jumpin : MonoBehaviour {

    private bool inVehicle = false;
    CarUserControl vehicleScript;
    public GameObject guiObj;
	public GameObject guiObj1;
    GameObject player;
    public GameObject carcam;
	public GameObject playercam;
	public Transform playercampos;

    void Start()
    {
        vehicleScript = GetComponent<CarUserControl>();
        player = GameObject.FindWithTag("Player");
		playercam = GameObject.Find ("Main Camera");
		playercampos.SetPositionAndRotation (playercam.transform.position, playercam.transform.rotation);
        guiObj.SetActive(false);
		carcam.SetActive(false);
		guiObj1.SetActive (false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && inVehicle == false)
        {
            guiObj.SetActive(true);
            if (Input.GetButtonDown("Fire2"))
            {
                guiObj.SetActive(false);
                player.transform.parent = gameObject.transform;
                vehicleScript.enabled = true;
				playercam.transform.parent = this.transform;
				playercam.transform.SetPositionAndRotation (carcam.transform.position, carcam.transform.rotation);
                player.SetActive(false);
                inVehicle = true;
                carcam.SetActive(false);
				guiObj1.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObj.SetActive(false);
        }
    }
    void Update()
    {
        if (inVehicle == true && Input.GetKey(KeyCode.F))
        {
            vehicleScript.enabled = false;
            player.SetActive(true);
            player.transform.parent = null;
            inVehicle = false;
            carcam.SetActive(false);
			playercam.transform.parent = player.transform;
			playercam.transform.SetPositionAndRotation (playercampos.position, playercampos.rotation);
			guiObj1.SetActive (false);
        }
    }
}
