using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 300f; //steer left and right
    [SerializeField] float moveSpeed = 1500f; //move forward and backward
    [SerializeField] float acceleration = 1.5f; //nitro
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //Get the SpriteRenderer component
    }

    void Update()
    {

        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed; //get button left and right
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; //get buttons to move forward and backward
        float nitroAmount = Input.GetButton("Jump") ? acceleration : 1; //get button to acceleration

        transform.Rotate(0, 0, -steerAmount); //steer left and right
        transform.Translate(0, moveAmount * 0.01f * nitroAmount, 0); //move forward and backward
        // if (Input.GetButton("Jump"))
        // {
        //     spriteRenderer.sprite = Resources.Load<Sprite>("Car 3_nitro");
        // } else {
        //     spriteRenderer.sprite = Resources.Load<Sprite>("Car 3");
        // }
    }
}