using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class titlescreen : MonoBehaviour
{

    public GameObject titlemenu;
    public GameObject start;
    public GameObject start2;
    public GameObject options;
    public GameObject aaudio;

    public AudioMixer audioMixer;

    public int gameplayAudio;
    public int musicAudio;


    void Start()
    {

        titlemenu.SetActive(true);
        start.SetActive(false);
        options.SetActive(false);
        aaudio.SetActive(false);

    } 

    public void Loadlevel1 ()
    {

        SceneManager.LoadScene ("test 02");

    }

    public void Loadlevel2()
    {

        SceneManager.LoadScene("PlanetsTest");

    }

    public void Quit ()
    {

        Application.Quit();

    }

    public void titleMenu()
    {

        titlemenu.SetActive(true);
        start.SetActive(false);
        start2.SetActive(false);
        options.SetActive(false);
        aaudio.SetActive(false);

    }

    public void sStart()
    {

        titlemenu.SetActive(false);
        start.SetActive(true);
        start2.SetActive(false);
        options.SetActive(false);
        aaudio.SetActive(false);

    }

    public void sStart2()
    {

        titlemenu.SetActive(false);
        start.SetActive(false);
        start2.SetActive(true);
        options.SetActive(false);
        aaudio.SetActive(false);

    }

    public void Options()
    {

        titlemenu.SetActive(false);
        start.SetActive(false);
        start2.SetActive(false);
        options.SetActive(true);
        aaudio.SetActive(false);

    }

    public void Audio()
    {

        titlemenu.SetActive(false);
        start.SetActive(false);
        start2.SetActive(false);
        options.SetActive(false);
        aaudio.SetActive(true);

    }

    public void setGameplayAudio(float gamAud)
    {

        audioMixer.SetFloat("GameAudio", gamAud);

    }

    public void setMusicAudio(float musAud)
    {

        audioMixer.SetFloat("MusAudio", musAud);

    }

}
