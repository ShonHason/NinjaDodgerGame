using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player" && gameObject.tag != "Hit")
        {
        GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";
        }
    }
}
