using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
    private static GameFlowManager instance = null;

    public static GameFlowManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameFlowManager>();

                if(instance == null)
                {
                    Debug.LogError("GameFlowManager not Found");
                }
            }

            return instance;
        }
    }

    [Header("UI")]
    public UIGameOver GameOverUI;

    public bool IsGameOver {get {return isGameOver; }}

    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    public void GameOver()
    {
        isGameOver = true;
        ScoreManager.Instance.SetHighScore();
        GameOverUI.Show();
        SoundManager.Instance.StopBGM();
    }
    
}//class
