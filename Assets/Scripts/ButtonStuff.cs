using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStuff : MonoBehaviour
{
    public bool pressed = false;
    public GameObject[] playerUI;

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


    public void Button1() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 0; pressed = true; }
    public void Button2() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 1; pressed = true; }
    public void Button3() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 2; pressed = true; }
    public void Button4() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 3; pressed = true; }
    public void Button5() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 4; pressed = true; }
    public void Button6() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 5; pressed = true; }
    public void Button7() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 6; pressed = true; }
    public void Button8() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 7; pressed = true; }
    public void Button9() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 8; pressed = true; }
    public void Button10() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 9; pressed = true; }
    public void Button11() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 10; pressed = true; }
    public void Button12() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 11; pressed = true; }
    public void Button13() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 12; pressed = true; }
    public void Button14() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 13; pressed = true; }
    public void Button15() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 14; pressed = true; }
    public void Button16() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 15; pressed = true; }
    public void Button17() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 16; pressed = true; }
    public void Button18() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 17; pressed = true; }
    public void Button19() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 18; pressed = true; }
    public void Button20() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 19; pressed = true; }
    public void Button21() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 20; pressed = true; }
    public void Button22() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 21; pressed = true; }
    public void Button23() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 22; pressed = true; }
    public void Button24() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 23; pressed = true; }
    public void Button25() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 24; pressed = true; }
    public void Button26() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 25; pressed = true; }
    public void Button27() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 26; pressed = true; }
    public void Button28() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 27; pressed = true; }
    public void Button29() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 28; pressed = true; }
    public void Button30() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 29; pressed = true; }
    public void Button31() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 30; pressed = true; }
    public void Button32() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 31; pressed = true; }
    public void Button33() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 32; pressed = true; }
    public void Button34() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 33; pressed = true; }
    public void Button35() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 34; pressed = true; }
    public void Button36() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 35; pressed = true; }
    public void Button37() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 36; pressed = true; }
    public void Button38() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 37; pressed = true; }
    public void Button39() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 38; pressed = true; }
    public void Button40() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 39; pressed = true; }
    public void Button41() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 40; pressed = true; }
    public void Button42() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 41; pressed = true; }
    public void Button43() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 42; pressed = true; }
    public void Button44() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 43; pressed = true; }
    public void Button45() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 44; pressed = true; }
    public void Button46() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 45; pressed = true; }
    public void Button47() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 46; pressed = true; }
    public void Button48() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 47; pressed = true; }
    public void Button49() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 48; pressed = true; }
    public void Button50() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 49; pressed = true; }
    public void Button51() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 50; pressed = true; }
    public void Button52() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 51; pressed = true; }
    public void Button53() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 52; pressed = true; }
    public void Button54() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 53; pressed = true; }
}
