using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roaming : MonoBehaviour
{
    public Transform target;
    public Transform[] spaces;
    public float targetY;
    public float targetX;
    public float currentX;
    public float currentY;
    public int rand;
    public int newTarget;
    public float speed;
    public int moves = 3;
    public int movement;
    public GameObject checker;
    public float checkX;
    public float checkY;
    public float stuck;
    public bool attack;
    public bool attackP;

    private void Start()
    {
        ChangeTargetRand();
    }

    void Update()
    {
        currentX = Mathf.Round(transform.position.x * 100) / 100;
        currentY = Mathf.Round(transform.position.y * 100) / 100;
        targetX = Mathf.Round(target.position.x * 100) / 100;
        targetY = Mathf.Round(target.position.y * 100) / 100;
        checkX = Mathf.Round(checker.transform.position.x * 100) / 100;
        checkY = Mathf.Round(checker.transform.position.y * 100) / 100;

        if (moves <= 0)
        {
            moves = 0;
            StopMove();
        }
        else
        {
            if (currentX < targetX)
            {
                MovementR();
            }
            else if (currentX > targetX)
            {
                MovementL();
            }
            else if (currentY < targetY)
            {
                MovementU();
            }
            else if (currentY > targetY)
            {
                MovementD();
            }
        }

        if (currentX == targetX && currentY == targetY)
        {
            StopMove();
            moves = 0;
            CheckPlayer();
            ChangeTargetRand();
        }
    }


    void MovementR()
    {
        //Checks if it can move to the right...
        checker.GetComponent<Checker>().CheckRight();
        checker.GetComponent<Checker>().check = false;

        //...if it can, it does
        if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
        {
            MoveRight();

            if (currentX >= checkX)
            {
                checker.GetComponent<Checker>().check = true;
            }
        }
        //...if not, it tries going around
        else
        {
            stuck = 1;
            checker.GetComponent<Checker>().check = false;
        }
    }

    void MovementL()
    {
        //Checks if it can move to the left...
        checker.GetComponent<Checker>().CheckLeft();
        checker.GetComponent<Checker>().check = false;

        //...if it can, it does
        if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
        {
            MoveLeft();

            if (currentX <= checkX)
            {
                checker.GetComponent<Checker>().check = true;
            }
        }
        //...if not, it tries going around
        else
        {
            stuck = 2;
            checker.GetComponent<Checker>().check = false;
        }
    }

    void MovementU()
    {
        //Checks if it can move up...
        checker.GetComponent<Checker>().CheckUp();
        checker.GetComponent<Checker>().check = false;

        //...if it can, it does
        if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
        {
            MoveUp();

            if (currentY >= checkY)
            {
                checker.GetComponent<Checker>().check = true;
            }
        }
        //...if not, it tries going around
        else
        {
            stuck = 3;
            checker.GetComponent<Checker>().check = false;
        }
    }

    void MovementD()
    {
        //Checks if it can move down...
        checker.GetComponent<Checker>().CheckDown();
        checker.GetComponent<Checker>().check = false;

        //...if it can, it does
        if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
        {
            MoveDown();

            if (currentY <= checkY)
            {
                checker.GetComponent<Checker>().check = true;
            }
        }
        //...if not, it tries going around
        else
        {
            stuck = 4;
            checker.GetComponent<Checker>().check = false;
        }
    }


    void MoveUp()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.up * speed);
    }

    void MoveDown()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.down * speed);
    }

    void MoveLeft()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.left * speed);
    }

    void MoveRight()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.right * speed);
    }

    void StopMove()
    {
        transform.Translate(Vector2.zero);
    }

    public void ChangeTargetRand()
    {
        rand = Random.Range(0, spaces.Length);
        
        if (spaces[rand].GetComponent<GridMap>().navigable)
        {
            target = spaces[rand];
        }
        else
        {
            ChangeTargetRand();
        }
    }

    public void ChangeTarget()
    {
        target = spaces[newTarget];
        moves = movement;
    }

    public void CheckPlayer()
    {
        int counting = 0;
        checker.GetComponent<Checker>().check = true;

        if (counting <= 0)
        {
            checker.GetComponent<Checker>().CheckRight();

            if (!checker.GetComponent<Checker>().isPlayer)
            {
                counting = 1;
            }
            else
            {
                AttackPlayer();
            }
        }
        else if (counting == 1)
        {
            checker.GetComponent<Checker>().CheckLeft();

            if (!checker.GetComponent<Checker>().isPlayer)
            {
                counting = 2;
            }
            else
            {
                AttackPlayer();
            }
        }
        else if (counting == 2)
        {
            checker.GetComponent<Checker>().CheckUp();

            if (!checker.GetComponent<Checker>().isPlayer)
            {
                counting = 3;
            }
            else
            {
                AttackPlayer();
            }
        }
        else if (counting == 3)
        {
            checker.GetComponent<Checker>().CheckDown();

            if (!checker.GetComponent<Checker>().isPlayer)
            {
                counting = 4;
            }
            else
            {
                AttackPlayer();
            }
        }
        else if (counting > 5)
        {
            checker.GetComponent<Checker>().transform.position = transform.position;
            return;
        }
    }

    public void CheckPanther()
    {
        int counting = 0;
        checker.GetComponent<Checker>().check = true;

        if (counting <= 0)
        {
            checker.GetComponent<Checker>().CheckRight();

            if (!checker.GetComponent<Checker>().isPanther)
            {
                counting = 1;
            }
            else
            {
                AttackPanther();
            }
        }
        else if (counting == 1)
        {
            checker.GetComponent<Checker>().CheckLeft();

            if (!checker.GetComponent<Checker>().isPanther)
            {
                counting = 2;
            }
            else
            {
                AttackPanther();
            }
        }
        else if (counting == 2)
        {
            checker.GetComponent<Checker>().CheckUp();

            if (!checker.GetComponent<Checker>().isPanther)
            {
                counting = 3;
            }
            else
            {
                AttackPanther();
            }
        }
        else if (counting == 3)
        {
            checker.GetComponent<Checker>().CheckDown();

            if (!checker.GetComponent<Checker>().isPanther)
            {
                counting = 4;
            }
            else
            {
                AttackPanther();
            }
        }
        else if (counting > 5)
        {
            checker.GetComponent<Checker>().transform.position = transform.position;
            return;
        }
    }

    public void AttackPlayer()
    {
        attack = true;
    }

    public void AttackPanther()
    {
        attackP = true;
    }
}