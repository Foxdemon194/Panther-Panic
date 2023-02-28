using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScale : MonoBehaviour
{
    public Camera cam;
    public float camSize;

    public GameObject ui;
    public float uiSizeX;
    public float uiSizeY;
    public Vector2 uiScale;

    void Update()
    {
        if (camSize <= 0.1f)
        {
            camSize = 0.1f;
        }

        if (uiSizeX <= 0.1f)
        {
            uiSizeX = 0.1f;
        }

        if (uiSizeY <= 0.1f)
        {
            uiSizeY = 0.1f;
        }

        uiScale = new Vector2(uiSizeX, uiSizeY);

        ui.GetComponent<RectTransform>().localScale = uiScale;

        cam.orthographicSize = camSize;
    }
}
