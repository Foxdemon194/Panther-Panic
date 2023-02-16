using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStuff : MonoBehaviour
{
    public GameObject gButton;
    public GameObject dButton;
    public GameObject action;
    public GameObject character;
    public bool pressed = false;
    public GameObject[] playerUI;

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
        gButton.SetActive(false);
        dButton.SetActive(true);
    }

    public void Move()
    {
        dButton.SetActive(false);
        gButton.SetActive(true);
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


    public void Move1() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 0; pressed = true; }
    public void Move2() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 1; pressed = true; }
    public void Move3() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 2; pressed = true; }
    public void Move4() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 3; pressed = true; }
    public void Move5() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 4; pressed = true; }
    public void Move6() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 5; pressed = true; }
    public void Move7() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 6; pressed = true; }
    public void Move8() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 7; pressed = true; }
    public void Move9() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 8; pressed = true; }
    public void Move10() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 9; pressed = true; }
    public void Move11() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 10; pressed = true; }
    public void Move12() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 11; pressed = true; }
    public void Move13() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 12; pressed = true; }
    public void Move14() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 13; pressed = true; }
    public void Move15() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 14; pressed = true; }
    public void Move16() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 15; pressed = true; }
    public void Move17() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 16; pressed = true; }
    public void Move18() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 17; pressed = true; }
    public void Move19() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 18; pressed = true; }
    public void Move20() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 19; pressed = true; }
    public void Move21() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 20; pressed = true; }
    public void Move22() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 21; pressed = true; }
    public void Move23() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 22; pressed = true; }
    public void Move24() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 23; pressed = true; }
    public void Move25() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 24; pressed = true; }
    public void Move26() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 25; pressed = true; }
    public void Move27() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 26; pressed = true; }
    public void Move28() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 27; pressed = true; }
    public void Move29() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 28; pressed = true; }
    public void Move30() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 29; pressed = true; }
    public void Move31() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 30; pressed = true; }
    public void Move32() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 31; pressed = true; }
    public void Move33() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 32; pressed = true; }
    public void Move34() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 33; pressed = true; }
    public void Move35() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 34; pressed = true; }
    public void Move36() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 35; pressed = true; }
    public void Move37() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 36; pressed = true; }
    public void Move38() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 37; pressed = true; }
    public void Move39() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 38; pressed = true; }
    public void Move40() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 39; pressed = true; }
    public void Move41() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 40; pressed = true; }
    public void Move42() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 41; pressed = true; }
    public void Move43() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 42; pressed = true; }
    public void Move44() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 43; pressed = true; }
    public void Move45() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 44; pressed = true; }
    public void Move46() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 45; pressed = true; }
    public void Move47() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 46; pressed = true; }
    public void Move48() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 47; pressed = true; }
    public void Move49() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 48; pressed = true; }
    public void Move50() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 49; pressed = true; }
    public void Move51() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 50; pressed = true; }
    public void Move52() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 51; pressed = true; }
    public void Move53() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 52; pressed = true; }
    public void Move54() { GameObject.FindGameObjectWithTag("Manage").GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().newTarget = 53; pressed = true; }

    /*
    public void Decoy1() {  }
    public void Decoy2() {  }
    public void Decoy3() {  }
    public void Decoy4() {  }
    public void Decoy5() {  }
    public void Decoy6() {  }
    public void Decoy7() {  }
    public void Decoy8() {  }
    public void Decoy9() {  }
    public void Decoy10() {  }
    public void Decoy11() {  }
    public void Decoy12() {  }
    public void Decoy13() {  }
    public void Decoy14() {  }
    public void Decoy15() {  }
    public void Decoy16() {  }
    public void Decoy17() {  }
    public void Decoy18() {  }
    public void Decoy19() {  }
    public void Decoy20() {  }
    public void Decoy21() {  }
    public void Decoy22() {  }
    public void Decoy23() {  }
    public void Decoy24() {  }
    public void Decoy25() {  }
    public void Decoy26() {  }
    public void Decoy27() {  }
    public void Decoy28() {  }
    public void Decoy29() {  }
    public void Decoy30() {  }
    public void Decoy31() {  }
    public void Decoy32() {  }
    public void Decoy33() {  }
    public void Decoy34() {  }
    public void Decoy35() {  }
    public void Decoy36() {  }
    public void Decoy37() {  }
    public void Decoy38() {  }
    public void Decoy39() {  }
    public void Decoy40() {  }
    public void Decoy41() {  }
    public void Decoy42() {  }
    public void Decoy43() {  }
    public void Decoy44() {  }
    public void Decoy45() {  }
    public void Decoy46() {  }
    public void Decoy47() {  }
    public void Decoy48() {  }
    public void Decoy49() {  }
    public void Decoy50() {  }
    public void Decoy51() {  }
    public void Decoy52() {  }
    public void Decoy53() {  }
    public void Decoy54() {  }
    */
}
