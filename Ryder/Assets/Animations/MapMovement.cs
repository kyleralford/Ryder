using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public FloatReference mapSpeed;
    private bool mapMoving;
    private Vector3 mapTranslateValue;
    private float distanceTraveled;

    void Start()
    {
        mapMoving = false;
        mapTranslateValue = new Vector3(0, -mapSpeed.Value, 0);
    }

    void MapStart()
    {
        mapMoving = true;
    }

    void MapStop()
    {
        mapMoving = false;
    }

    void Update()
    {
        if (mapMoving)
        {
            transform.Translate(mapTranslateValue * Time.deltaTime, Space.Self);
            distanceTraveled += mapSpeed.Value * Time.deltaTime;
            if (distanceTraveled > 300)
            {
                distanceTraveled -= 300;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 300);
            }
        }
    }
}
