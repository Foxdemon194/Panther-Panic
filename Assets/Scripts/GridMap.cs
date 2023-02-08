using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    public bool touch = false;
    public bool stopped;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && touch == false)
        {
            collision.gameObject.GetComponent<Roaming>().moves--;
            touch = true;
        }

        if (collision.gameObject.tag == "Player" && touch == false)
        {
            collision.gameObject.GetComponent<PlayerMove>().moves--;
            touch = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.GetComponent<Roaming>().moves <= 0)
            {
                stopped = true;
                Move(collision.gameObject);
            }
        }

        if (collision.gameObject.tag == "Player")
        {
            if (collision.GetComponent<PlayerMove>().moves <= 0)
            {
                stopped = true;
                Move(collision.gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && touch == true)
        {
            touch = false;
        }

        if (collision.gameObject.tag == "Player" && touch == true)
        {
            touch = false;
        }
    }

    void Move(GameObject obj)
    {
        while (stopped)
        {
            obj.transform.position = Vector2.MoveTowards(obj.transform.position, transform.position, 0.01f * Time.deltaTime);

            if (obj.transform.position == transform.position)
            {
                stopped = false;
            }
        }
    }
}
