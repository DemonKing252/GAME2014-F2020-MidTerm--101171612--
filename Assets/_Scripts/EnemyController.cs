using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
File:       BackgroundController.cs
Author:     Tom Tsiliopoulos (Revised by: Liam Blake)
Created:    2020-10-21 (To Revise)
Modified:   2020-10-21
Last Revision:
    Changed it so that the enemies are positioned on the right side and scroll up/down with a vertical boundary.

*/
public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
