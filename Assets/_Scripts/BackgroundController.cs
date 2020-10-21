using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
File:       BackgroundController.cs
Author:     Tom Tsiliopoulos (Revised by: Liam Blake)
Created:    2020-10-21 (To Revise)
Modified:   2020-10-21
Last Revision:
    Changed it so that the BG scrolls from right to left instead of top to bottom.

*/

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        // New change: Reset the BG to the right side of the screen.
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        // New change: Scroll from left to right.
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // New change: Checking if the BG scrolled off the left side of the screen.
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
