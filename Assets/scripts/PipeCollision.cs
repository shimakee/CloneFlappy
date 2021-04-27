using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCollision : MonoBehaviour
{
    public PipeSpawner PipeSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            Debug.Log("hit wall");
            PipeSpawner.Pipes.Enqueue(this.gameObject);
            this.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Player")
            Debug.Log("score");
    }
}
