using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GDOS : MonoBehaviour
{

    public GameObject GDOSMenu;
    public GameObject CommandLine;


    public void CommandLinePage()
    {

        GDOSMenu.SetActive(false);
        CommandLine.SetActive(true);

    }

    public void OSMenu()
    {

        GDOSMenu.SetActive(true);
        CommandLine.SetActive(false);

    }

    public void Loadlevel1()
    {

        SceneManager.LoadScene("ShipEditor");

    }

    public void Quit()
    {

        Application.Quit();

    }

}
