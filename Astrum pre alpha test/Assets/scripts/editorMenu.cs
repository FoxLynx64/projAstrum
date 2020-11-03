using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class editorMenu : MonoBehaviour
{

    public GameObject tab1;
    public GameObject tab2;
    public GameObject tab3;


    void Start()
    {

        tab1.SetActive(true);
        tab2.SetActive(true);
        tab3.SetActive(true);

    }

    public void Loadlevel1()
    {

        SceneManager.LoadScene("test 02");

    }

    public void Tab1()
    {

        tab1.SetActive(true);
        tab2.SetActive(true);
        tab3.SetActive(true);

    }

    public void Tab2()
    {

        tab1.SetActive(false);
        tab2.SetActive(true);
        tab3.SetActive(true);

    }

    public void Tab3()
    {

        tab1.SetActive(false);
        tab2.SetActive(false);
        tab3.SetActive(true);

    }

}
