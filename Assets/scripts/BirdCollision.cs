using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Current.EndGame();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Current.ModifyScore(10);
    }
}
