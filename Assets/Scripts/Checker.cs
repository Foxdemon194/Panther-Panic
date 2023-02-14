using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public GameObject player;
    public GameObject grid;
    public int test;
    public bool onGrid;
    public float test2;

    void Update()
    {
        if (grid == null)
        {
            return;
        }

        if (test <= 0 && onGrid == true)
        {
            Debug.Log("Grid");
            ParentGrid();
            test = 1;
        }
        else if (test > 0 && onGrid == false)
        {
            Debug.Log("Player");
            ParentPlayer();
            test = 0;
        }

        if (test2 > 2)
        {
            test2 = 2;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            grid = collision.gameObject;
            onGrid = true;
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
