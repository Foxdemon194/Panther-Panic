using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetColor : MonoBehaviour
{
    void Update()
    {
        if (this.gameObject == GameObject.FindGameObjectWithTag("test").GetComponent<Roaming>().target.gameObject)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}
