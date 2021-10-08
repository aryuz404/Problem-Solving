using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefabs;

    [SerializeField]
    private SpriteRenderer topWall, bottomWall, rightWall, leftWall;
    

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
        int randomBox = Random.Range(4, 10);

        for(int i = 0; i < randomBox; i++)
        {
            float minX = leftWall.transform.position.x + leftWall.bounds.size.x;
            float maxX = rightWall.transform.position.x - rightWall.bounds.size.x;
            float x = Random.Range(minX, maxX);

            float minY = topWall.transform.position.y - topWall.bounds.size.y;
            float maxY = bottomWall.transform.position.y + bottomWall.bounds.size.y;
            float y = Random.Range(minY, maxY);

            Vector3 boxPosition = new Vector3(x, y);

            if((boxPosition - CircleMovement.Instance.circlePosition).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(boxPrefabs, boxPosition, Quaternion.identity, transform);
            }
            
        }
        
    }

}//class
