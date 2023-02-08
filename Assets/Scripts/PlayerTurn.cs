using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    public GameObject[] players;
    public GameObject activePlayer;
    public GameObject[] enemy;
    public GameObject buttonMenu;
    public int num;

    public bool playersTurn;
    public bool enemysTurn;
    public int enTest;

    int test = 0;

    void Start()
    {
        activePlayer = players[num];
        playersTurn = true;
    }

    void Update()
    {
        if (activePlayer.GetComponent<PlayerMove>().moves <= 0 && playersTurn == false)
        {
            EnemysTurn();
        }

        if (playersTurn == true)
        {
            PlayersTurn();
        }

        activePlayer = players[num];
    }

    public void EnemysTurn()
    {
        if (test <= 0)
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].GetComponent<Roaming>().moves = enemy[i].GetComponent<Roaming>().movement;
                enTest++;
            }

            test++;
        }
        else
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                if (enemy[i].GetComponent<Roaming>().moves == 0)
                {
                    enTest--;
                }
            }

            if (enTest <= 0)
            {
                enemysTurn = false;
                playersTurn = true;
                test = 0;
            }
        }
    }

    public void PlayersTurn()
    {
        buttonMenu.SetActive(true);

        if (buttonMenu.GetComponent<ButtonStuff>().pressed == true)
        {
            buttonMenu.GetComponent<ButtonStuff>().pressed = false;
            activePlayer.GetComponent<PlayerMove>().ChangeTarget();
            buttonMenu.SetActive(false);
            playersTurn = false;
            enemysTurn = true;
        }
    }
}
