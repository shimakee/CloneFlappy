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
    private float time;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        if (pipePrefab == null)
            throw new NullReferenceException("Game object pipe prefab should not be null");
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnTimer)
        {
            time = 0;
            var pipe = GameObject.Instantiate(pipePrefab);
            pipe.transform.position = this.transform.position;
        }
    }
}
