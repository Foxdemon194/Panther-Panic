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
    public Roaming[] enComp;
    public Checker[] enChecker;
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
        apComp = activePlayer.GetComponent<PlayerMove>();

        playersTurn = true;
    }

    void Update()
    {
        activePlayer = players[num];
        apComp = activePlayer.GetComponent<PlayerMove>();
        apChecker = activePlayer.GetComponent<PlayerMove>().checker.GetComponent<Checker>();

        for (int i = 0; i < enemy.Length; i++)
        {
            enComp[i] = enemy[i].GetComponent<Roaming>();
            enChecker[i] = enemy[i].gameObject.GetComponent<Roaming>().checker.GetComponent<Checker>();
        }


        if (apComp.moves <= 0 && playersTurn == false)
        {
            EnemysTurn();
        }

        if (playersTurn == true)
        {
            PlayersTurn();
        }

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
        //Don't make two grids that are horizontally adjacent unnavigable since it will ignore the second grid
        //Can fix l a t e r

        //All for PLAYER vvvvv
        if (apComp.stuck > 0)
        {
            if (apComp.moves <= 0)
            {
                return;
            }

            //Makes the player go up one space vvv
            if (apComp.stuck == 1 && maNum <= 0)
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
            if (apComp.stuck == 2 && maNum <= 0)
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
            if (apComp.stuck == 3 && maNum <= 0)
            {
                apComp.enabled = false;
                apChecker.enabled = false;
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.left * 0.74f);
                touch = true;
                maNum = 1;
            }
            else if (canMove && apComp.stuck == 3 && maNum == 1)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 3 && maNum == 2)
            {
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.up * 0.782f);
                touch = true;
                maNum = 3;
            }
            if (canMove && apComp.stuck == 3 && maNum == 3)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 3 && maNum == 4)
            {
                apChecker.enabled = true;
                apChecker.CheckRight();
                maNum = -1;
                apComp.stuck = 0;
            }
            //^^^


            //Makes the player go right one space vvv
            if (apComp.stuck == 4 && maNum <= 0)
            {
                apComp.enabled = false;
                apChecker.enabled = false;
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.right * 0.74f);
                touch = true;
                maNum = 1;
            }
            else if (canMove && apComp.stuck == 4 && maNum == 1)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 4 && maNum == 2)
            {
                transform.position = activePlayer.transform.position;
                transform.Translate(Vector2.down * 0.782f);
                touch = true;
                maNum = 3;
            }
            if (canMove && apComp.stuck == 4 && maNum == 3)
            {
                StartCoroutine(LP(transform.position, 0.3f));
            }
            else if (apComp.stuck == 4 && maNum == 4)
            {
                apChecker.enabled = true;
                apChecker.CheckLeft();
                maNum = -1;
                apComp.stuck = 0;
            }
            //^^^
        }
        
        if (maNum <= -1)
        {
            transform.position = new Vector2(50, 50);
            apComp.enabled = true;
            apChecker.enabled = true;
            maNum = 0;
        }
        //^^^^^

        //Enemy vvv
        for (int i = 0; i < enemy.Length; i++)
        {
            //All for Enemy vvvvv
            if (enComp[i].stuck > 0)
            {
                if (enComp[i].moves <= 0)
                {
                    return;
                }

                //Makes the enemy go up one space vvv
                if (enComp[i].stuck == 1 && maNum <= 0)
                {
                    transform.position = enemy[i].transform.position;
                    transform.Translate(Vector2.up * 0.782f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && enComp[i].stuck == 1 && maNum == 1)
                {
                    StartCoroutine(ELP(transform.position, 0.3f, i));
                }
                else if (enComp[i].stuck == 1 && maNum == 2)
                {
                    maNum = -1;
                    enComp[i].stuck = 0;
                }
                //^^^

                //Makes the enemy go down one space vvv
                if (enComp[i].stuck == 2 && maNum <= 0)
                {
                    transform.position = enemy[i].transform.position;
                    transform.Translate(Vector2.down * 0.782f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && enComp[i].stuck == 2 && maNum == 1)
                {
                    StartCoroutine(ELP(transform.position, 0.3f, i));
                }
                else if (enComp[i].stuck == 2 && maNum == 2)
                {
                    maNum = -1;
                    enComp[i].stuck = 0;
                }
                //^^^

                //Makes the enemy go left one space vvv
                if (enComp[i].stuck == 3 && maNum <= 0)
                {
                    enComp[i].enabled = false;
                    enChecker[i].enabled = false;
                    transform.position = enemy[i].transform.position;
                    transform.Translate(Vector2.left * 0.74f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && enComp[i].stuck == 3 && maNum == 1)
                {
                    StartCoroutine(ELP(transform.position, 0.3f, i));
                }
                else if (enComp[i].stuck == 3 && maNum == 2)
                {
                    transform.position = enemy[i].transform.position;
                    transform.Translate(Vector2.up * 0.782f);
                    touch = true;
                    maNum = 3;
                }
                if (canMove && enComp[i].stuck == 3 && maNum == 3)
                {
                    StartCoroutine(ELP(transform.position, 0.3f, i));
                }
                else if (enComp[i].stuck == 3 && maNum == 4)
                {
                    enChecker[i].enabled = true;
                    enChecker[i].CheckRight();
                    maNum = -1;
                    enComp[i].stuck = 0;
                }
                //^^^


                //Makes the enemy go right one space vvv
                if (enComp[i].stuck == 4 && maNum <= 0)
                {
                    enComp[i].enabled = false;
                    enChecker[i].enabled = false;
                    transform.position = enemy[i].transform.position;
                    transform.Translate(Vector2.right * 0.74f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && enComp[i].stuck == 4 && maNum == 1)
                {
                    StartCoroutine(ELP(transform.position, 0.3f, i));
                }
                else if (enComp[i].stuck == 4 && maNum == 2)
                {
                    transform.position = enemy[i].transform.position;
                    transform.Translate(Vector2.down * 0.782f);
                    touch = true;
                    maNum = 3;
                }
                if (canMove && enComp[i].stuck == 4 && maNum == 3)
                {
                    StartCoroutine(ELP(transform.position, 0.3f, i));
                }
                else if (enComp[i].stuck == 4 && maNum == 4)
                {
                    enChecker[i].enabled = true;
                    enChecker[i].CheckLeft();
                    maNum = -1;
                    enComp[i].stuck = 0;
                }
                //^^^
            }

            if (maNum <= -1)
            {
                transform.position = new Vector2(50, 50);
                enComp[i].enabled = true;
                enChecker[i].enabled = true;
                maNum = 0;
            }
            //^^^^^
        }
        //^^^
    }

    IEnumerator LP(Vector2 newPosition, float duration)
    {
        float t = 0;

        while (t < duration)
        {
            activePlayer.transform.position = Vector2.Lerp(activePlayer.transform.position, newPosition, t / duration);
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

    IEnumerator ELP(Vector2 newPosition, float duration, int i)
    {
        float t = 0;

        while (t < duration)
        {
            enemy[i].transform.position = Vector2.Lerp(enemy[i].transform.position, newPosition, t / duration);
            t += Time.deltaTime;
            yield return null;
        }

        enemy[i].transform.position = newPosition;

        if (enemy[i].transform.position.x == newPosition.x && enemy[i].transform.position.y == newPosition.y)
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
