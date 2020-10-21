using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
File:       BulletController.cs
Author:     Tom Tsiliopoulos (Revised by: Liam Blake)
Created:    2020-10-21 (To Revise)
Modified:   2020-10-21
Last Revision:
    Changed it so that the bullets scroll from right to left.

*/
public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        // Change here: bullets move left
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {

        // Change here: checking if the bullets reached past the left side of the screen.
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
