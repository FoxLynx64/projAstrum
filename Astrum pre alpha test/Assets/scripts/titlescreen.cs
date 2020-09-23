using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlescreen : MonoBehaviour {

    public GameObject titlemenu;
    public GameObject options;
    public GameObject audio;

    void Start()
    {

        titlemenu.SetActive(true);
        options.SetActive(false);
        audio.SetActive(false);

    } 

    public void Loadlevel ()
    {

        SceneManager.LoadScene ("test");

    }

    public void Quit ()
    {

        Application.Quit();

    }

    public void titleMenu()
    {

        titlemenu.SetActive(true);
        options.SetActive(false);
        audio.SetActive(false);

    }

    public void Options()
    {

        titlemenu.SetActive(false);
        options.SetActive(true);
        audio.SetActive(false);

    }

    public void Audio()
    {

        titlemenu.SetActive(false);
        options.SetActive(false);
        audio.SetActive(true);

    }
}
