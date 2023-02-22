using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    public GameObject[] players;
    public GameObject activePlayer;
    public PlayerMove apComp;
    public GameObject[] enemy;
    public GameObject buttonMenu;
    public int num;

    public bool playersTurn;
    public bool enemysTurn;
    public int enTest;

    int test = 0;

    public Collider2D col;
    public bool touch;
    public bool canMove;

    void Start()
    {
        activePlayer = players[num];
        apComp = activePlayer.GetComponent<PlayerMove>();
        playersTurn = true;
    }

    void Update()
    {
        if (apComp.moves <= 0 && playersTurn == false)
        {
            EnemysTurn();
        }

        if (playersTurn == true)
        {
            PlayersTurn();
        }

        activePlayer = players[num];

        MoveAround();
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
            apComp.ChangeTarget();
            buttonMenu.SetActive(false);
            playersTurn = false;
            enemysTurn = true;
        }
    }

    public void MoveAround()
    {
        if (apComp.stuck > 0)
        {
            if (activePlayer.GetComponentInChildren<Checker>().enabled == true && apComp.enabled == true)
            {
                col.transform.position = activePlayer.transform.position;
                col.transform.Translate(Vector2.up * 0.782f);
                touch = true;
            }

            activePlayer.GetComponentInChildren<Checker>().enabled = false;
            apComp.enabled = false;

            if (apComp.stuck == 1)
            {
                if (canMove)
                {
                    StartCoroutine(LP(col.transform.position, 1));
                }
            }
        }
    }

    IEnumerator LP(Vector2 newPosition, float duration)
    {
        float t = 0;
        Vector2 currentPosition = activePlayer.transform.position;

        while (t < duration)
        {
            activePlayer.transform.position = Vector2.Lerp(currentPosition, newPosition, t / duration);
            t += Time.deltaTime;
            yield return null;
        }

        activePlayer.transform.position = newPosition;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            Debug.Log("Hii");
            if (touch)
            {
                Debug.Log("Heey");
                canMove = true;
                touch = false;
            }
        }
    }
}
