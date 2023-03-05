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

    public GameObject[] panther;
    public Panther[] pComp;
    public Checker[] pChecker;
    public int rescuedPanthers;

    public bool playersTurn;
    public bool enemysTurn;
    public int enTest;

    int test = 0;

    public bool touch;
    public bool canMove;

    int maNum = 0;
    int counting = 0;
    public int[] playerCount;
    public int[] pantherCount;

    public GameObject winMenu;
    public GameObject loseMenu;

    void Start()
    {
        for (int i = 0; i < playerCount.Length; i++)
        {
            playerCount[i] = 0;
        }

        for (int i = 0; i < pantherCount.Length; i++)
        {
            pantherCount[i] = 0;
        }

        apComp = activePlayer.GetComponent<PlayerMove>();

        playersTurn = true;
    }

    void Update()
    {
        activePlayer = players[num];
        apComp = activePlayer.GetComponent<PlayerMove>();
        apChecker = activePlayer.GetComponent<PlayerMove>().checker.GetComponent<Checker>();

        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].GetComponent<PlayerMove>().hurt)
            {
                playerCount[i] = 1;
            }

            if (SumArray(playerCount) >= players.Length)
            {
                loseMenu.SetActive(true);
                Time.timeScale = 0;
            }
        }

        for (int i = 0; i < panther.Length; i++)
        {
            if (panther[i].GetComponent<Panther>().hurt)
            {
                pantherCount[i] = 1;
            }

            if (SumArray(pantherCount) >= panther.Length)
            {
                loseMenu.SetActive(true);
                Time.timeScale = 0;
            }
        }

        for (int i = 0; i < enemy.Length; i++)
        {
            enComp[i] = enemy[i].GetComponent<Roaming>();
            enChecker[i] = enemy[i].gameObject.GetComponent<Roaming>().checker.GetComponent<Checker>();
        }

        for (int i = 0; i < panther.Length; i++)
        {
            pComp[i] = panther[i].GetComponent<Panther>();
            pChecker[i] = panther[i].gameObject.GetComponent<Panther>().checker.GetComponent<Checker>();
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

        if (apComp.rescue)
        {
            for (int i = 0; i < panther.Length; i++)
            {
                if (pComp[i].canRescue)
                {
                    pComp[i].rAttempts -= apComp.trust;

                    pComp[i].canRescue = false;


                    if (pComp[i].rAttempts <= 0)
                    {
                        panther[i].SetActive(false);
                        rescuedPanthers++;
                    }
                    else
                    {
                        pComp[i].moves = pComp[i].movement;
                        pComp[i].canRescue = false;
                    }

                    pComp[i].ChangeTargetRand();
                    apComp.rescue = false;
                }
            }
        }

        for (int i = 0; i < enemy.Length; i++)
        {
            if (enComp[i].attack)
            {
                for (int x = 0; x < players.Length; x++)
                {
                    if (players[x].GetComponent<PlayerMove>().attacked)
                    {
                        players[x].GetComponent<PlayerMove>().health--;

                        players[x].GetComponent<PlayerMove>().attacked = false;

                        enComp[i].attack = false;
                    }
                }
            }

            if (enComp[i].attackP)
            {
                for (int x = 0; x < panther.Length; x++)
                {
                    if (pComp[x].attacked)
                    {
                        pComp[x].health--;

                        pComp[x].attacked = false;

                        pComp[x].moves = pComp[x].movement;

                        pComp[x].ChangeTargetRand();

                        enComp[i].attack = false;
                    }
                }
            }
        }

        //Win screen
        //maybe play music here too?
        if (rescuedPanthers >= panther.Length)
        {
            Time.timeScale = 0;
            winMenu.SetActive(true);
        }
    }

    public void EnemysTurn()
    {
        if (test <= 0)
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                enComp[i].CheckPlayer();
                enComp[i].CheckPanther();
                enComp[i].moves = enComp[i].movement;
                enTest++;
            }

            test++;
        }
        else
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                if (enComp[i].moves == 0)
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
                apChecker.check = true;
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
                apChecker.check = true;
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
                apChecker.check = true;
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
                apChecker.check = true;
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

        //Panthers vvv
        for (int i = 0; i < panther.Length; i++)
        {
            //All for Panthers vvvvv
            if (pComp[i].stuck > 0)
            {
                if (pComp[i].moves <= 0)
                {
                    return;
                }

                //Makes the panther go up one space vvv
                if (pComp[i].stuck == 1 && maNum <= 0)
                {
                    transform.position = panther[i].transform.position;
                    transform.Translate(Vector2.up * 0.782f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && pComp[i].stuck == 1 && maNum == 1)
                {
                    StartCoroutine(PLP(transform.position, 0.3f, i));
                }
                else if (pComp[i].stuck == 1 && maNum == 2)
                {
                    maNum = -1;
                    pComp[i].stuck = 0;
                }
                //^^^

                //Makes the panther go down one space vvv
                if (pComp[i].stuck == 2 && maNum <= 0)
                {
                    transform.position = panther[i].transform.position;
                    transform.Translate(Vector2.down * 0.782f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && pComp[i].stuck == 2 && maNum == 1)
                {
                    StartCoroutine(PLP(transform.position, 0.3f, i));
                }
                else if (pComp[i].stuck == 2 && maNum == 2)
                {
                    maNum = -1;
                    pComp[i].stuck = 0;
                }
                //^^^

                //Makes the panther go left one space vvv
                if (pComp[i].stuck == 3 && maNum <= 0)
                {
                    pComp[i].enabled = false;
                    pChecker[i].enabled = false;
                    transform.position = panther[i].transform.position;
                    transform.Translate(Vector2.left * 0.74f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && pComp[i].stuck == 3 && maNum == 1)
                {
                    StartCoroutine(PLP(transform.position, 0.3f, i));
                }
                else if (pComp[i].stuck == 3 && maNum == 2)
                {
                    transform.position = panther[i].transform.position;
                    transform.Translate(Vector2.up * 0.782f);
                    touch = true;
                    maNum = 3;
                }
                if (canMove && pComp[i].stuck == 3 && maNum == 3)
                {
                    StartCoroutine(PLP(transform.position, 0.3f, i));
                }
                else if (pComp[i].stuck == 3 && maNum == 4)
                {
                    pChecker[i].enabled = true;
                    pChecker[i].CheckRight();
                    maNum = -1;
                    pComp[i].stuck = 0;
                }
                //^^^


                //Makes the panther go right one space vvv
                if (pComp[i].stuck == 4 && maNum <= 0)
                {
                    pComp[i].enabled = false;
                    pChecker[i].enabled = false;
                    transform.position = panther[i].transform.position;
                    transform.Translate(Vector2.right * 0.74f);
                    touch = true;
                    maNum = 1;
                }
                else if (canMove && pComp[i].stuck == 4 && maNum == 1)
                {
                    StartCoroutine(PLP(transform.position, 0.3f, i));
                }
                else if (pComp[i].stuck == 4 && maNum == 2)
                {
                    transform.position = panther[i].transform.position;
                    transform.Translate(Vector2.down * 0.782f);
                    touch = true;
                    maNum = 3;
                }
                if (canMove && pComp[i].stuck == 4 && maNum == 3)
                {
                    StartCoroutine(PLP(transform.position, 0.3f, i));
                }
                else if (pComp[i].stuck == 4 && maNum == 4)
                {
                    pChecker[i].enabled = true;
                    pChecker[i].CheckLeft();
                    maNum = -1;
                    pComp[i].stuck = 0;
                }
                //^^^
            }

            if (maNum <= -1)
            {
                transform.position = new Vector2(50, 50);
                pComp[i].enabled = true;
                pChecker[i].enabled = true;
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
    IEnumerator PLP(Vector2 newPosition, float duration, int i)
    {
        float t = 0;

        while (t < duration)
        {
            panther[i].transform.position = Vector2.Lerp(panther[i].transform.position, newPosition, t / duration);
            t += Time.deltaTime;
            yield return null;
        }

        panther[i].transform.position = newPosition;

        if (panther[i].transform.position.x == newPosition.x && panther[i].transform.position.y == newPosition.y)
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

    public void CheckPanther()
    {
        apChecker.check = true;

        if (counting <= 0)
        {
            apChecker.CheckRight();

            if (apChecker.isPanther)
            {
                apComp.Rescue();
            }
            else
            {
                counting = 1;
            }
        }
        if (counting == 1)
        {
            apChecker.CheckLeft();

            if (apChecker.isPanther)
            {
                apComp.Rescue();
            }
            else
            {
                counting = 2;
            }
        }
        if (counting == 2)
        {
            apChecker.CheckUp();

            if (apChecker.isPanther)
            {
                apComp.Rescue();
            }
            else
            {
                counting = 3;
            }
        }
        if (counting == 3)
        {
            apChecker.CheckDown();

            if (apChecker.isPanther)
            {
                apComp.Rescue();
            }
            else
            {
                counting = 4;
            }
        }
        if (counting >= 4)
        {
            apChecker.transform.position = activePlayer.transform.position;
            counting = 0;
            return;
        }
    }

    public int SumArray(int[] toBeSummed)
    {
        int sum = 0;

        foreach (int item in toBeSummed)
        {
            sum += item;
        }

        return sum;
    }
}
