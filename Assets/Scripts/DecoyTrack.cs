using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyTrack : MonoBehaviour
{
    public int i = 0;

    void Update()
    {
        if (i >= GetComponentInParent<Decoy>().enemies.Length)
        {
            i = GetComponentInParent<Decoy>().enemies.Length;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GetComponentInParent<Decoy>().enemies[i] = collision.gameObject;
            i++;
        }
    }
}
