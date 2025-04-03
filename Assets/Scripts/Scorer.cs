using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;


    private void OnCollisionEnter(Collision other)
{   Debug.Log("Collision detected");

    if (other.gameObject.tag != "Hit")
    {   
        hits++;
        Debug.Log("You have bumped into something " + hits + " times");
    }
}

}
