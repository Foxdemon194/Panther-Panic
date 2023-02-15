using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public GameObject player;
    public GameObject grid;
    public bool onGrid;
    public bool nav;
    public float test2;
    public float test1;

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
        else
        {
            ParentPlayer();
        }

        if (test2 > 2)
        {
            test2 = 2;
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            grid = collision.gameObject;
            onGrid = true;
            nav = collision.GetComponent<GridMap>().navigable;
            
            if (test1 <= 0 && player.gameObject.tag == "Player")
            {
                player.GetComponent<PlayerMove>().moves--;
                test1++;
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

        test2 = 0;
    }

    public void CheckUp()
    {
        if (test2 <= 0)
        {
            ParentPlayer();

            transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 1);

            test2++;
        }
    }
    public void CheckDown()
    {
        if (test2 <= 0)
        {
            ParentPlayer();

            transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 1);

            test2++;
        }
    }
    public void CheckRight()
    {
        if (test2 <= 0)
        {
            ParentPlayer();

            transform.position = new Vector2(player.transform.position.x + 1, player.transform.position.y);

            test2++;
        }
    }
    public void CheckLeft()
    {
        if (test2 <= 0)
        {
            ParentPlayer();

            transform.position = new Vector2(player.transform.position.x - 1, player.transform.position.y);

            test2++;
        }
    }
}
