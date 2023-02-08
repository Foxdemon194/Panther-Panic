using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public bool test = false;
    public bool player = true;

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            test = false;
        }
        if (collision.gameObject.tag == "Player")
        {
            player = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grid")
        {
            test = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            player = true;
        }
    }
}
