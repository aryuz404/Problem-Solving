using UnityEngine;


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
    

    public int HighScore {get { return highScore; }}
    public int CurrentScore {get {return currentScore; }}

    private int currentScore;
    private static int highScore;

    private void Start() 
    {
        ResetCurrentScore();
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void AddScore(int value)
    {
        currentScore += value;
        SoundManager.Instance.PlayHit();
    }

    public void SetHighScore()
    {
        highScore = currentScore;
    }
    
}//class
