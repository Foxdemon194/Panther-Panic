using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStuff : MonoBehaviour
{
    public GameObject help;
    public GameObject pause;
    public GameObject action;
    public GameObject character;
    public bool pressed = false;
    public bool gButton;
    public GameObject[] playerUI;

    public GameObject decoy;

    public void Decoy()
    {
        Instantiate(decoy, 
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.transform.position, 
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.transform.rotation);
    }

    public void Back()
    {
        character.SetActive(false);
        action.SetActive(true);
    }

    public void Characters()
    {
        action.SetActive(false);
        character.SetActive(true);
    }

    public void Move()
    {
        gButton = true;
    }

    public void Paused()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void Help()
    {
        help.SetActive(true);
    }

    public void HBack()
    {
        help.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game 2");
        Time.timeScale = 1;
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void Player1()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 0;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[0].SetActive(true);
        Back();
    }

    public void Player2()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 1;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[1].SetActive(true);
        Back();
    }

    public void Player3()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 2;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[2].SetActive(true);
        Back();
    }

    public void Player4()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 3;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[3].SetActive(true);
        Back();
    }

    
    public void Button1()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 0; pressed = true;
        }
    }
    public void Button2()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 1; pressed = true;
        }
    }
    public void Button3()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 2; pressed = true;
        }
    }
    public void Button4()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 3; pressed = true;
        }
    }
    public void Button5()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 4; pressed = true;
        }
    }
    public void Button6()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 5; pressed = true;
        }
    }
    public void Button7()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 6; pressed = true;
        }
    }
    public void Button8()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 7; pressed = true;
        }
    }
    public void Button9()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 8; pressed = true;
        }
    }
    public void Button10()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 9; pressed = true;
        }
    }
    public void Button11()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 10; pressed = true;
        }
    }
    public void Button12()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 11; pressed = true;
        }
    }
    public void Button13()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 12; pressed = true;
        }
    }
    public void Button14()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 13; pressed = true;
        }
    }
    public void Button15()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 14; pressed = true;
        }
    }
    public void Button16()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 15; pressed = true;
        }
    }
    public void Button17()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 16; pressed = true;
        }
    }
    public void Button18()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 17; pressed = true;
        }
    }
    public void Button19()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 18; pressed = true;
        }
    }
    public void Button20()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 19; pressed = true;
        }
    }
    public void Button21()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 20; pressed = true;
        }
    }
    public void Button22()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 21; pressed = true;
        }
    }
    public void Button23()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 22; pressed = true;
        }
    }
    public void Button24()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 23; pressed = true;
        }
    }
    public void Button25()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 24; pressed = true;
        }
    }
    public void Button26()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 25; pressed = true;
        }
    }
    public void Button27()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 26; pressed = true;
        }
    }
    public void Button28()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 27; pressed = true;
        }
    }
    public void Button29()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 28; pressed = true;
        }
    }
    public void Button30()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 29; pressed = true;
        }
    }
    public void Button31()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 30; pressed = true;
        }
    }
    public void Button32()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 31; pressed = true;
        }
    }
    public void Button33()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 32; pressed = true;
        }
    }
    public void Button34()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 33; pressed = true;
        }
    }
    public void Button35()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 34; pressed = true;
        }
    }
    public void Button36()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 35; pressed = true;
        }
    }
    public void Button37()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 36; pressed = true;
        }
    }
    public void Button38()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 37; pressed = true;
        }
    }
    public void Button39()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 38; pressed = true;
        }
    }
    public void Button40()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 39; pressed = true;
        }
    }
    public void Button41()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 40; pressed = true;
        }
    }
    public void Button42()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 41; pressed = true;
        }
    }
    public void Button43()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 42; pressed = true;
        }
    }
    public void Button44()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 43; pressed = true;
        }
    }
    public void Button45()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 44; pressed = true;
        }
    }
    public void Button46()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 45; pressed = true;
        }
    }
    public void Button47()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 46; pressed = true;
        }
    }
    public void Button48()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 47; pressed = true;
        }
    }
    public void Button49()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 48; pressed = true;
        }
    }
    public void Button50()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 49; pressed = true;
        }
    }
    public void Button51()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 50; pressed = true;
        }
    }
    public void Button52()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 51; pressed = true;
        }
    }
    public void Button53()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 52; pressed = true;
        }
    }
    public void Button54()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 53; pressed = true;
        }
    }
}
