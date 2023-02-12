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
    public GameObject check;
    public bool checking;

    void Start()
    {
        ChangeTargetRand();
    }

    void Update()
    {
        currentX = Mathf.Round(transform.position.x * 100) / 100;
        currentY = Mathf.Round(transform.position.y * 100) / 100;
        targetX = Mathf.Round(target.position.x * 100) / 100;
        targetY = Mathf.Round(target.position.y * 100) / 100;

        if (moves <= 0)
        {
            StopMove();
            CheckPlayer();
        }
        if (moves > 0)
        {
            CheckPlayer();

            if (currentX < targetX)
            {
                MoveRight();
            }
            else if (currentX > targetX)
            {
                MoveLeft();
            }
            else if (currentY < targetY)
            {
                MoveUp();
            }
            else if (currentY > targetY)
            {
                MoveDown();
            }
        }

        if (currentX == targetX && currentY == targetY)
        {
            ChangeTargetRand();
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
        target = spaces[rand];
    }

    public void ChangeTarget()
    {
        target = spaces[newTarget];
        moves = movement;
    }

    public void CheckPlayer()
    {
        check.transform.position = new Vector2(transform.position.x + 1.4f, transform.position.y);

        if (check.GetComponent<Checker>().player == false)
        {
            check.transform.position = new Vector2(transform.position.x - 1.4f, transform.position.y);

            if (check.GetComponent<Checker>().player == false)
            {
                check.transform.position = new Vector2(transform.position.x, transform.position.y + 1.4f);

                if (check.GetComponent<Checker>().player == false)
                {
                    check.transform.position = new Vector2(transform.position.x, transform.position.y - 1.4f);

                    if (check.GetComponent<Checker>().player == false)
                    {
                        check.transform.position = transform.position;
                    }
                    else
                    {
                        //attack player on bottom side
                        AttackPlayer();
                    }
                }
                else
                {
                    //attack player on top side
                    AttackPlayer();
                }
            }
            else
            {
                //attack player on left side
                AttackPlayer();
            }
        }
        else
        {
            //attack player on right side
            AttackPlayer();
        }
    }

    public void AttackPlayer()
    {
        
    }
}