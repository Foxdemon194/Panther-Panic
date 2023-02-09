using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Decoy : MonoBehaviour
{
    public GameObject[] enemies;

    void Update()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] == null)
            {
                return;
            }

            enemies[i].GetComponent<Roaming>().target = transform;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].GetComponent<Roaming>().moves = 0;
                enemies[i].GetComponent<Roaming>().ChangeTargetRand();
            }

            Destroy(gameObject);
        }
    }
}
