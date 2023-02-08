using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
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

    void Update()
    {
        //Rework the checker thing; it sucks

        currentX = Mathf.Round(transform.position.x * 100) / 100;
        currentY = Mathf.Round(transform.position.y * 100) / 100;
        targetX = Mathf.Round(target.position.x * 100) / 100;
        targetY = Mathf.Round(target.position.y * 100) / 100;
        checking = check.GetComponent<Checker>().test;

        if (moves <= 0)
        {
            StopMove();
        }
        if (moves > 0)
        {
            if (currentX < targetX)
            {
                check.transform.position = new Vector2(transform.position.x + 1f, transform.position.y);
                //MoveRight();

                if (checking == true)
                {
                    check.transform.position = check.transform.position;
                    check.transform.parent = null;
                    MoveRight();
                }
                if (checking == false)
                {
                    //idk yet
                    StopMove();
                }
            }
            else if (currentX > targetX)
            {
                check.transform.position = new Vector2(transform.position.x - 1f, transform.position.y);
                //MoveLeft();

                if (checking == true)
                {
                    check.transform.position = check.transform.position;
                    check.transform.parent = null;
                    MoveLeft();
                }
                if (checking == false)
                {
                    //idk yet
                    StopMove();
                }
            }
            else if (currentY < targetY)
            {
                check.transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
                //MoveUp();

                if (checking == true)
                {
                    check.transform.position = check.transform.position;
                    check.transform.parent = null;
                    MoveUp();
                }
                if (checking == false)
                {
                    //idk yet
                    StopMove();
                }
            }
            else if (currentY > targetY)
            {
                check.transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
                //MoveDown();

                if (checking == true)
                {
                    check.transform.position = check.transform.position;
                    check.transform.parent = null;
                    MoveDown();
                }
                if (checking == false)
                {
                    //idk yet
                    StopMove();
                }
            }
        }

        if (currentX == targetX && currentY == targetY)
        {
            StopMove();
            moves = 0;
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

    public void ChangeTarget()
    {
        target = spaces[newTarget];
        moves = movement;
    }
}