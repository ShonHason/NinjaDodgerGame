using UnityEngine;

public class Mover : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    { 
        movePlayer();
    }
    
    void printInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit walls or objects!");
    }
    
    void movePlayer()
    {
        float varX = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float varY = 0f;
        float varZ = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(varX,varY,varZ);
    }
}
