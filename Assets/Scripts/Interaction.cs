using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject parent;

    public bool panther;
    public bool player;
    public bool enemy;

    void OnEnable()
    {
        panther = false;
        enemy = false;
        player = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != parent.tag)
        {
            if (collision.tag == "Panther")
            {
                if (parent.tag == "Player")
                {
                    panther = true;
                }

                if (parent.tag == "Enemy")
                {
                    panther = true;
                }

                gameObject.SetActive(false);
            }

            if (collision.tag == "Player")
            {
                if (parent.tag == "Enemy")
                {
                    player = true;
                }

                if (parent.tag == "Panther")
                {
                    player = true;
                }

                gameObject.SetActive(false);
            }

            if (collision.tag == "Enemy")
            {
                if (parent.tag == "Player")
                {
                    enemy = true;
                }

                if (parent.tag == "Panther")
                {
                    enemy = true;
                }

                gameObject.SetActive(false);
            }
        }
    }
}
