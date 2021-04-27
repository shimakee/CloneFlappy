using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Current;
    public static bool GameStarted = false;

    [SerializeField]
    private GameObject bird;
    [SerializeField]
    private PipeSpawner pipeSpawner;
    [SerializeField]
    private GameObject UICanvas;

    private void Awake()
    {
        if(Current == null)
            Current = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("StartGame");
        GameStarted = true;
        bird.SetActive(true);
        bird.transform.position = Vector2.zero;
        var rb = bird.GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;

        pipeSpawner.StartSpawn();
        UICanvas.SetActive(false);
    }
    public void EndGame()
    {
        Debug.Log("end game");
        GameStarted = false;
        var rb = bird.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        bird.transform.position = Vector2.zero;
        bird.SetActive(false);

        pipeSpawner.EndSpawn();
        UICanvas.SetActive(true);
    }
}
