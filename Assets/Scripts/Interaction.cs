using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject parent;

    public bool panther;
    public bool player;
    public bool enemy;
    public int parentVal;
    public int colVal;

    void OnEnable()
    {
        panther = false;
        enemy = false;
        player = false;
    }

    private void Update()
    {
        if (parent.gameObject.tag == "Panther")
        {
            parentVal = 3;
        }
        else if (parent.gameObject.tag == "Enemy")
        {
            parentVal = 2;
        }
        else if (parent.gameObject.tag == "Player")
        {
            parentVal = 1;
        }


        if (parentVal == 1)
        {
            if (colVal == 2)
            {
                enemy = true;
            }

            if (colVal == 3)
            {
                panther = true;
            }
        }
        else if (parentVal == 2)
        {
            if (colVal == 1)
            {
                player = true;
            }

            if (colVal == 3)
            {
                panther = true;
            }
        }
        else if (parentVal == 3)
        {
            if (colVal == 1)
            {
                player = true;
            }

            if (colVal == 2)
            {
                enemy = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != parent.tag)
        {
            if (collision.tag == "Panther")
            {
                colVal = 3;
            }

            if (collision.tag == "Player")
            {
                colVal = 1;
            }

            if (collision.tag == "Enemy")
            {
                colVal = 2;
            }
        }
    }
}
