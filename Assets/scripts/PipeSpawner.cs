using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;
    [SerializeField]
    private float spawnTimer = 2;
    [SerializeField]
    private int spawnLimit = 10;
    private float time;
    public Queue<GameObject> Pipes = new Queue<GameObject>();

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        if (pipePrefab == null)
            throw new NullReferenceException("Game object pipe prefab should not be null");

        for (int i = 0; i < spawnLimit; i++)
        {
            var pipe = GameObject.Instantiate(pipePrefab);
            pipe.transform.position = this.transform.position;
            var pipeCollision = pipe.GetComponent<PipeCollision>();
            if(pipeCollision != null)
                pipeCollision.PipeSpawner = this;
            Pipes.Enqueue(pipe);
        }

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnTimer)
        {
            time = 0;

            var pipe = Pipes.Dequeue();
            pipe.SetActive(true);
            pipe.transform.position = this.transform.position;
            
        }
    }
}
