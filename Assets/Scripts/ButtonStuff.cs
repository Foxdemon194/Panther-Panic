using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStuff : MonoBehaviour
{
    public GameObject action;
    public GameObject character;
    public bool pressed = false;
    public bool gButton;
    public bool dButton;
    public GameObject[] playerUI;

    public GameObject decoy;

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

    public void Decoy()
    {
        gButton = false;
        dButton = true;
    }

    public void Move()
    {
        gButton = true;
        dButton = false;
    }

    public void Player1()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 0;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[0].SetActive(true);
    }

    public void Player2()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 1;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[1].SetActive(true);
    }

    public void Player3()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 2;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[2].SetActive(true);
    }

    public void Player4()
    {
        GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().num = 3;

        for (int i = 0; i < playerUI.Length; i++)
        {
            playerUI[i].SetActive(false);
        }

        playerUI[3].SetActive(true);
    }


    public void Button1()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 0; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[0]);
        }
    }

    public void Button2()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 1; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[1]);
        }
    }
    public void Button3()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 2; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[2]);
        }
    }
    public void Button4()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 3; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[3]);
        }
    }
    public void Button5()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 4; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[4]);
        }
    }
    public void Button6()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 5; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[5]);
        }
    }
    public void Button7()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 6; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[6]);
        }
    }
    public void Button8()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 7; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[7]);
        }
    }
    public void Button9()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 8; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[8]);
        }
    }
    public void Button10()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 9; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[9]);
        }
    }
    public void Button11()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 10; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[10]);
        }
    }
    public void Button12()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 11; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[11]);
        }
    }
    public void Button13()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 12; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[12]);
        }
    }
    public void Button14()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 13; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[13]);
        }
    }
    public void Button15()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 14; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[14]);
        }
    }
    public void Button16()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 15; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[15]);
        }
    }
    public void Button17()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 16; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[16]);
        }
    }
    public void Button18()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 17; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[17]);
        }
    }
    public void Button19()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 18; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[18]);
        }
    }
    public void Button20()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 19; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[19]);
        }
    }
    public void Button21()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 20; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[20]);
        }
    }
    public void Button22()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 21; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[21]);
        }
    }
    public void Button23()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 22; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[22]);
        }
    }
    public void Button24()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 23; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[23]);
        }
    }
    public void Button25()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 24; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[24]);
        }
    }
    public void Button26()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 25; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[25]);
        }
    }
    public void Button27()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 26; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[26]);
        }
    }
    public void Button28()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 27; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[27]);
        }
    }
    public void Button29()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 28; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[28]);
        }
    }
    public void Button30()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 29; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[29]);
        }
    }
    public void Button31()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 30; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[30]);
        }
    }
    public void Button32()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 31; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[31]);
        }
    }
    public void Button33()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 32; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[32]);
        }
    }
    public void Button34()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 33; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[33]);
        }
    }
    public void Button35()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 34; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[34]);
        }
    }
    public void Button36()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 35; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[35]);
        }
    }
    public void Button37()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 36; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[36]);
        }
    }
    public void Button38()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 37; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[37]);
        }
    }
    public void Button39()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 38; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[38]);
        }
    }
    public void Button40()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 39; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[39]);
        }
    }
    public void Button41()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 40; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[40]);
        }
    }
    public void Button42()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 41; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[41]);
        }
    }
    public void Button43()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 42; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[42]);
        }
    }
    public void Button44()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 43; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[43]);
        }
    }
    public void Button45()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 44; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[44]);
        }
    }

    public void Button46()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 45; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[45]);
        }
    }

    public void Button47()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 46; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[46]);
        }
    }

    public void Button48()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 47; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[47]);
        }
    }

    public void Button49()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 48; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[48]);
        }
    }

    public void Button450()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 49; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[49]);
        }
    }

    public void Button51()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 50; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[50]);
        }
    }

    public void Button52()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 51; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[51]);
        }
    }

    public void Button53()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 52; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[52]);
        }
    }

    public void Button54()
    {
        if (gButton)
        {
            GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 53; pressed = true;
        }

        if (dButton)
        {
            Instantiate(decoy, GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().spaces[53]);
        }
    }
}
