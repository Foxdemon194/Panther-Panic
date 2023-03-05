using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public GameObject player;
    public GameObject grid;
    public bool onGrid;
    public bool nav;
    public float test1;
    public bool check;
    public bool isPlayer;
    public bool isPanther;

    void Update()
    {
        if (grid == null)
        {
            return;
        }

        if (onGrid)
        {
            if (nav)
            {
                ParentGrid();
            }
        }

        if (test1 > 2)
        {
            test1 = 2;
        }

        if (player.tag == "Player")
        {
            if (player.GetComponent<PlayerMove>().moves <= 0)
            {
                test1 = 0;
            }
        }
    }

    public void ParentPlayer()
    {
        transform.parent = player.transform;
        transform.position = player.transform.position;
    }

    public void ParentGrid()
    {
        transform.parent = grid.transform;
        transform.position = grid.transform.position;
    }

    public void CheckUp()
    {
        if (check)
        {
            ParentPlayer();

            transform.position = new Vector2(transform.position.x, transform.position.y + 0.782f);
        }
    }
    public void CheckDown()
    {
        if (check)
        {
            ParentPlayer();

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.782f);
        }
    }
    public void CheckRight()
    {
        if (check)
        {
            ParentPlayer();

            transform.position = new Vector2(transform.position.x + 0.74f, transform.position.y);
        }
    }
    public void CheckLeft()
    {
        if (check)
        {
            ParentPlayer();

            transform.position = new Vector2(transform.position.x - 0.74f, transform.position.y);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            grid = collision.gameObject;
            onGrid = true;
            nav = grid.GetComponent<GridMap>().navigable;
        }

        if (collision.gameObject.tag == "Player")
        {
            isPlayer = true;

            if (player.tag == "Enemy")
            {
                collision.GetComponent<PlayerMove>().attacked = true;
            }
        }

        if (collision.gameObject.tag == "Panther")
        {
            isPanther = true;

            if (player.tag == "Player")
            {
                collision.GetComponent<Panther>().canRescue = true;
            }

            if (player.tag == "Enemy")
            {
                collision.GetComponent<Panther>().attacked = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            grid = null; 
            onGrid = false;
        }

        if (collision.gameObject.tag == "Player")
        {
            isPlayer = false;
            collision.GetComponent<PlayerMove>().attacked = false;
        }

        if (collision.gameObject.tag == "Panther")
        {
            isPanther = false;
            collision.GetComponent<Panther>().canRescue = false;
        }
    }
}
