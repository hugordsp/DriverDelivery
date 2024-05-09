using UnityEngine;

public class followCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;    
    //This camera position should be the same as the player position

    void LateUpdate() //LateUpdate is called after Update

    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
