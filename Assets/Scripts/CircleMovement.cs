using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    private static CircleMovement instance;

    public static CircleMovement Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<CircleMovement>();

                if(instance == null)
                {
                    Debug.LogError("CircleMovement not found");
                }
            }
            return instance;
        }
    }

    private Rigidbody2D rb;
    private Vector3 mousePosition;

    public Vector3 circlePosition;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveCircle();
    }

    void MoveCircle()
    {
        if(Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
        }

        circlePosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {

        if(collision.CompareTag("Box"))
        {
            collision.gameObject.SetActive(false);
            ScoreManager.Instance.AddScore(1);
            StartCoroutine(BoxSpawner.Instance.RespawnBox());

        }
    }

}//class
