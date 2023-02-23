using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MenuStuff : MonoBehaviour
{
    //make a quick menu system, then include animation stuff later
    public GameObject menu;
    public GameObject play;
    public GameObject levels;
    public GameObject htp;
    public GameObject credits;

    public void Menu()
    {
        SetInactive();
        menu.SetActive(true);
    }

    public void Play()
    {
        SetInactive();
        play.SetActive(true);
    }

    public void Levels()
    {
        SetInactive();
        levels.SetActive(true);
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("Game 2");
    }

    public void HowToPlay()
    {
        SetInactive();
        htp.SetActive(true);
    }

    public void Credits()
    {
        SetInactive();
        credits.SetActive(true);
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    void SetInactive()
    {
        menu.SetActive(false);
        play.SetActive(false);
        levels.SetActive(false);
        htp.SetActive(false);
        credits.SetActive(false);
    }
}
