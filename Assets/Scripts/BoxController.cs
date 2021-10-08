using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBox();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBox()
    {
        int randomBox = Random.Range(1, 10);

        for(int i = 0; i < randomBox; i++)
        {
            Vector3 boxPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-3f, 3f), 0f);
            GameObject boxClone = Instantiate(box, boxPosition, Quaternion.identity);
        }
        
    }

}//class
