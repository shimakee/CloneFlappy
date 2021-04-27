using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullPipe : MonoBehaviour
{
    [SerializeField]
    private float spacing = 5;

    private GameObject _topPipe;
    private GameObject _botPipe;

    private void Awake()
    {
        _topPipe = gameObject.transform.GetChild(0).gameObject;
        _botPipe = gameObject.transform.GetChild(1).gameObject;

        float space = Random.Range(0, spacing);

        

        _topPipe.transform.position = new Vector2(_topPipe.transform.position.x, _topPipe.transform.position.y + space);
        _botPipe.transform.position = new Vector2(_botPipe.transform.position.x, _botPipe.transform.position.y - (spacing - space));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
