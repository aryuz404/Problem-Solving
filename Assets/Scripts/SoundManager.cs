using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance = null;

    public static SoundManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<SoundManager>();

                if(instance == null)
                {
                    Debug.LogError("SoundManager not Found");
                }
            }

            return instance;
        }
    }
    
    public AudioClip hitBox;

    private AudioSource player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void PlayHit()
    {
        player.PlayOneShot(hitBox);
    }

    public void StopBGM()
    {
        player.Stop();
    }

}//class
