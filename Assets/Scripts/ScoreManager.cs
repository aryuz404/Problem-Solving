using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    public static ScoreManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();

                if(instance == null)
                {
                    Debug.LogError("ScoreManager not found");
                }
            }
            return instance;
        }
    }
    
    [SerializeField]
    private Text scoreText;

    private int score = 0;

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
    
}//class
