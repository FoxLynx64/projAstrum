using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{

    public GameObject FirstPersonCam;
    public GameObject ThirdPersonCam;
    public GameObject FirstPersonGuide;
    public GameObject ThirdPersonGuide;
    public CameraMovement vehiclecamScript;


    void Start()
    {

        FirstPersonCam.SetActive(true);
        ThirdPersonCam.SetActive(false);
        FirstPersonGuide.SetActive(true);
        ThirdPersonGuide.SetActive(false);

        vehiclecamScript = ThirdPersonCam.GetComponent<CameraMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("q"))
        {

            if (FirstPersonCam.activeSelf == true)
            {

                FirstPersonCam.SetActive(false);
                ThirdPersonCam.SetActive(true);
                FirstPersonGuide.SetActive(false);
                ThirdPersonGuide.SetActive(true);

            }

            else if (ThirdPersonCam.activeSelf == true)
            {

                FirstPersonCam.SetActive(true);
                ThirdPersonCam.SetActive(false);
                FirstPersonGuide.SetActive(true);
                ThirdPersonGuide.SetActive(false);

            }

            else
            {

                FirstPersonCam.SetActive(false);
                ThirdPersonCam.SetActive(true);
                FirstPersonGuide.SetActive(false);
                ThirdPersonGuide.SetActive(true);

            }

        }

    }
}
