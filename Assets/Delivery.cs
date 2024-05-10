using UnityEngine;

public class Delivery : MonoBehaviour
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
        if (other.tag == "Package")
        {
            Debug.Log("Package pick up!");
        }

        if (other.tag == "Person")
        {
            Debug.Log("Package Delivered!");
        }
        // Debug.Log("Trigger detected with " + other.gameObject.name);
    }
}
