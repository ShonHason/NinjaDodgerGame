using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameObject.SetActive(false);

    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RocketMovment();
        DestroyWhenReached();
    }

    void RocketMovment()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void DestroyWhenReached()
    {
        if (playerPosition == transform.position)
        {
            Destroy(gameObject);
        }

    }
}
