using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public GameObject player;
    public GameObject grid;
    public int test;
    public bool onGrid;

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
        else if (test >= 0 && onGrid == false)
        {
            Debug.Log("Player");
            ParentPlayer();
            test = 0;
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
    }
}
