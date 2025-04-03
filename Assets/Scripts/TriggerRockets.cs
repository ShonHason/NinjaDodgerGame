using System;
using UnityEngine;

public class TriggerRockets : MonoBehaviour
{   
    [SerializeField] GameObject rocket1;
    [SerializeField] GameObject rocket2;
    [SerializeField] GameObject rocket3;
    [SerializeField] GameObject rocket4;
    [SerializeField] GameObject rocket5;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player")) {
            Console.WriteLine("Player has entered the trigger zone");
            rocket1.SetActive(true);
            rocket2.SetActive(true);
            rocket3.SetActive(true);
            rocket4.SetActive(true);
            rocket5.SetActive(true);
            Destroy(gameObject);    
        }
    }

}
