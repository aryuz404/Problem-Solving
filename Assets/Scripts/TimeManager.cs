using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private static TimeManager instance = null;

    public static TimeManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<TimeManager>();

                if(instance == null)
                {
                    Debug.LogError("TimeManager not Found");
                }
            }

            return instance;
        }
    }

    public int duration;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameFlowManager.Instance.IsGameOver)
        {
            return;
        }

        if(time > duration)
        {
            GameFlowManager.Instance.GameOver();
            return;
        }

        time += Time.deltaTime;
    }

    public float GetRemainingTime()
    {
        return duration - time;
    }
    
}//class
