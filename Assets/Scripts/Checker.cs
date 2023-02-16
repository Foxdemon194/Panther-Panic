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

    void Update()
    {
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
        ParentPlayer();

        transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 1);
    }
    public void CheckDown()
    {
        ParentPlayer();

        transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 1);
    }
    public void CheckRight()
    {
        ParentPlayer();

        transform.position = new Vector2(player.transform.position.x + 1, player.transform.position.y);
    }
    public void CheckLeft()
    {
        ParentPlayer();

        transform.position = new Vector2(player.transform.position.x - 1, player.transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            grid = collision.gameObject;
            onGrid = true;
            nav = grid.GetComponent<GridMap>().navigable;

            /*
            if (test1 <= 0 && player.gameObject.tag == "Player")
            {
                player.GetComponent<PlayerMove>().moves--;
                test1++;
            }
            */
        }
    }
}
