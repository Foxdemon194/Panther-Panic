using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMove : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MUp();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MDown();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MRight();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            MLeft();
        }
    }

    void MUp()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.up * 0.782f);
    }

    void MDown()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.down * 0.782f);
    }

    void MLeft()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.left * 0.74f);
    }

    void MRight()
    {
        transform.Translate(Vector2.zero);
        transform.Translate(Vector2.right * 0.74f);
    }
}
