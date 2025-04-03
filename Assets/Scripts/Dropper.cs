using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    float spawnTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
        spawnTime = Time.time; // Record the spawn time

    }
    void Update()
    {

        if (Time.time-spawnTime > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
