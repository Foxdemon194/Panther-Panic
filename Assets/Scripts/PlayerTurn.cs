using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    public GameObject[] players;
    public GameObject activePlayer;
    public PlayerMove apComp;
    public Checker apChecker;
    public GameObject[] enemy;
    public GameObject buttonMenu;
    public int num;

    public bool playersTurn;
    public bool enemysTurn;
    public int enTest;

    int test = 0;

    public bool touch;
    public bool canMove;

    public int maNum = 0;

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
        apChecker = activePlayer.GetComponent<PlayerMove>().checker.GetComponent<Checker>();

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
        //All for PLAYER vvvvv
        if (apComp.stuck > 0)
        {
            //Makes the player go up one space vvv
            if (maNum <= 0 && apComp.stuck == 1)
            {
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.up * 0.782f);
                touch = true;
                maNum = 1;
            }
            else if (canMove && apComp.stuck == 1 && maNum == 1)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 1 && maNum == 2)
            {
                maNum = -1;
                apComp.stuck = 0;
            }
            //^^^

            //Makes the player go down one space vvv
            if (maNum <= 0 && apComp.stuck == 2)
            {
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.down * 0.782f);
                touch = true;
                maNum = 1;
            }
            else if (canMove && apComp.stuck == 2 && maNum == 1)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 2 && maNum == 2)
            {
                maNum = -1;
                apComp.stuck = 0;
            }
            //^^^

            //Makes the player go left one space vvv
            if (maNum <= 0 && apComp.stuck == 3)
            {
                apChecker.enabled = false;
                apComp.enabled = false;
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.left * 0.74f);
                touch = true;
                maNum = 1;
            }
            else if (canMove && apComp.stuck == 3 && maNum == 1)
            {
                apComp.speed = 0;
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 3 && maNum == 2)
            {
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.up * 0.782f);
                touch = true;
            }
            else if (canMove && apComp.stuck == 3 && maNum == 3)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 3 && maNum == 4)
            {
                maNum = -1;
                apComp.stuck = 0;
            }
            //^^^

            
            //Makes the player go right one space vvv
            if (maNum <= 0 && apComp.stuck == 4)
            {
                apChecker.enabled = false;
                apComp.enabled = false;
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.right * 0.74f);
                touch = true;
                maNum = 1;
            }
            else if (canMove && apComp.stuck == 4 && maNum == 1)
            {
                apComp.speed = 0;
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 4 && maNum == 2)
            {
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.down * 0.782f);
                touch = true;
            }
            else if (canMove && apComp.stuck == 4 && maNum == 3)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 4 && maNum == 4)
            {
                maNum = -1;
                apComp.stuck = 0;
            }
            //^^^
        }
        
        if (maNum <= -1)
        {
            transform.position = new Vector2(0, 0);
            maNum = 0;
        }
        //^^^^^
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

        if (activePlayer.transform.position.x == newPosition.x && activePlayer.transform.position.y == newPosition.y)
        {
            maNum++;
            canMove = false;
            StopAllCoroutines();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            if (touch)
            {
                canMove = true;
                touch = false;
            }
        }
    }
}
