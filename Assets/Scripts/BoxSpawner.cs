using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    private static BoxSpawner instance;

    public static BoxSpawner Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<BoxSpawner>();

                if(instance == null)
                {
                    Debug.LogError("BoxSpawner not found");
                }
            }
            return instance;
        }
    }

    [SerializeField]
    private GameObject boxPrefabs;

    [SerializeField]
    private SpriteRenderer topWall, bottomWall, rightWall, leftWall;

    

    private readonly List<GameObject> boxPool = new List<GameObject>();

    private float respawnTime = 3.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        SpawnBox();
    }

    private Vector3 FindRandomPosition()
    {
        Vector3 boxPos;

        while(true)
        {
            float minX = leftWall.transform.position.x + leftWall.bounds.size.x;
            float maxX = rightWall.transform.position.x - rightWall.bounds.size.x;
            float x = Random.Range(minX, maxX);

            float minY = topWall.transform.position.y - topWall.bounds.size.y - 3;
            float maxY = bottomWall.transform.position.y + bottomWall.bounds.size.y;
            float y = Random.Range(minY, maxY);

            boxPos = new Vector3(x, y);

            if((boxPos - CircleMovement.Instance.circlePosition).magnitude < 3)
            {
                break;
            }
        }

        return boxPos;
    }


    private GameObject CreateOrFindBox()
    {
        GameObject box = boxPool.Find(b => !b.gameObject.activeSelf);

        if(box == null)
        {
            Vector3 boxPosition = FindRandomPosition();
            box = Instantiate(boxPrefabs, boxPosition, Quaternion.identity, transform).gameObject;

            boxPool.Add(box);
        }

        return box;
    }

    void SpawnBox()
    {
        int randomBox = Random.Range(4, 10);

        
        for(int i = 0; i < randomBox; i++)
        {
            
        Vector3 boxPosition = FindRandomPosition();

        GameObject box = Instantiate(boxPrefabs, boxPosition, Quaternion.identity, transform).gameObject;
            
        boxPool.Add(box);
            
        }
        
        
    }

    public IEnumerator RespawnBox()
    {
        yield return new WaitForSeconds(respawnTime);
        
        GameObject respawnBox = CreateOrFindBox();
        respawnBox.transform.position = FindRandomPosition();
        respawnBox.SetActive(true);
    }

}//class
