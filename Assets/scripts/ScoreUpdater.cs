using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI textMesh;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        if (textMesh == null)
            throw new NullReferenceException("text mesh must not be null");

    }

    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Current.OnScore += UpdateText;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void UpdateText(int score)
    {
        //Debug.Log($"score {score}");
        textMesh.text = score.ToString();
    }
}
