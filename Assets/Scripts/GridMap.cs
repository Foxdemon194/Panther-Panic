using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    public bool navigable;
    bool pPassed;
    bool ePassed;
    bool panther;
    public GameObject manager;
    public float tolerance = 0.01f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.gameObject == manager.GetComponent<PlayerTurn>().activePlayer)
            {
                pPassed = true;
            }
        }

        if (collision.tag == "Enemy")
        {
            for (int i = 0; i < manager.GetComponent<PlayerTurn>().enemy.Length; i++)
            {
                if (collision.gameObject == manager.GetComponent<PlayerTurn>().enemy[i])
                {
                    ePassed = true;
                }
            }
        }

        if (collision.tag == "Panther")
        {
            for (int i = 0; i < manager.GetComponent<PlayerTurn>().panther.Length; i++)
            {
                if (collision.gameObject == manager.GetComponent<PlayerTurn>().panther[i])
                {
                    panther = true;
                }
            }
        }
    }

    void Update()
    {
        if (pPassed)
        {
            if (manager.GetComponent<PlayerTurn>().activePlayer.transform.position == transform.position)
            {
                manager.GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().moves--;
            }
            else if (manager.GetComponent<PlayerTurn>().activePlayer.transform.position.x >= transform.position.x - tolerance ||
                     manager.GetComponent<PlayerTurn>().activePlayer.transform.position.x <= transform.position.x + tolerance)
            {
                if (manager.GetComponent<PlayerTurn>().activePlayer.transform.position.y >= transform.position.y - tolerance ||
                    manager.GetComponent<PlayerTurn>().activePlayer.transform.position.y <= transform.position.y + tolerance)
                {
                    manager.GetComponent<PlayerTurn>().activePlayer.GetComponent<PlayerMove>().moves--;
                    pPassed = false;
                }
            }
        }

        if (ePassed)
        {
            for (int i = 0; i < manager.GetComponent<PlayerTurn>().enemy.Length; i++)
            {
                if (manager.GetComponent<PlayerTurn>().enemy[i].transform.position == transform.position)
                {
                    manager.GetComponent<PlayerTurn>().enemy[i].GetComponent<Roaming>().moves--;
                }
                else if (manager.GetComponent<PlayerTurn>().enemy[i].transform.position.x >= transform.position.x - tolerance ||
                         manager.GetComponent<PlayerTurn>().enemy[i].transform.position.x <= transform.position.x + tolerance)
                {
                    if (manager.GetComponent<PlayerTurn>().enemy[i].transform.position.y >= transform.position.y - tolerance ||
                        manager.GetComponent<PlayerTurn>().enemy[i].transform.position.y <= transform.position.y + tolerance)
                    {
                        manager.GetComponent<PlayerTurn>().enemy[i].GetComponent<Roaming>().moves--;
                        ePassed = false;
                    }
                }
            }
        }

        if (panther)
        {
            for (int i = 0; i < manager.GetComponent<PlayerTurn>().panther.Length; i++)
            {
                if (manager.GetComponent<PlayerTurn>().panther[i].transform.position == transform.position)
                {
                    manager.GetComponent<PlayerTurn>().panther[i].GetComponent<Panther>().moves--;
                }
                else if (manager.GetComponent<PlayerTurn>().panther[i].transform.position.x >= transform.position.x - tolerance ||
                         manager.GetComponent<PlayerTurn>().panther[i].transform.position.x <= transform.position.x + tolerance)
                {
                    if (manager.GetComponent<PlayerTurn>().panther[i].transform.position.y >= transform.position.y - tolerance ||
                        manager.GetComponent<PlayerTurn>().panther[i].transform.position.y <= transform.position.y + tolerance)
                    {
                        manager.GetComponent<PlayerTurn>().panther[i].GetComponent<Panther>().moves--;
                        panther = false;
                    }
                }
            }
        }
    }
}
