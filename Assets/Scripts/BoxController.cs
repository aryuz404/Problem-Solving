using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if(collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            ScoreManager.Instance.AddScore(1);
        }
    }

}//class
