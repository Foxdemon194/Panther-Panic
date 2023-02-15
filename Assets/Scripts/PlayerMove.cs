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
    public GameObject checker;

    void Update()
    {
        //Rework the checker thing; it sucks

        currentX = Mathf.Round(transform.position.x * 100) / 100;
        currentY = Mathf.Round(transform.position.y * 100) / 100;
        targetX = Mathf.Round(target.position.x * 100) / 100;
        targetY = Mathf.Round(target.position.y * 100) / 100;

        if (moves <= 0)
        {
            StopMove();
        }
        if (moves > 0)
        {
            if (currentX < targetX)
            {
                checker.GetComponent<Checker>().CheckRight();

                if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
                {
                    MoveRight();
                }
                else
                {
                    Debug.Log("Stuck R");
                }
            }
            else if (currentX > targetX)
            {
                checker.GetComponent<Checker>().CheckLeft();

                if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
                {
                    MoveLeft();
                }
                else
                {
                    Debug.Log("Stuck L");
                }
            }
            else if (currentY < targetY)
            {
                checker.GetComponent<Checker>().CheckUp();

                if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
                {
                    MoveUp();
                }
                else
                {
                    Debug.Log("Stuck U");
                }
            }
            else if (currentY > targetY)
            {
                checker.GetComponent<Checker>().CheckDown();

                if (checker.GetComponent<Checker>().onGrid == true && checker.GetComponent<Checker>().nav == true)
                {
                    MoveDown();
                }
                else
                {
                    Debug.Log("Stuck D");
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