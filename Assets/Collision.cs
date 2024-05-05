using UnityEngine;

public class Collision : MonoBehaviour
{
    //Collision method: it detects when the object collides with something
    void OnCollisionEnter2D(Collision2D other)   
    {
        Debug.Log("Collision detected with " + other.gameObject.name);
    }
    //Trigger method: it detects when the object collides with something
    //Needs to activate the Is Trigger in Box Collider Component
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Trigger detected with " + other.gameObject.name);
    }
}
