using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 400f;
    [SerializeField] float moveSpeed = 600f;

    [SerializeField] float acceleration = 3f;


    void Start()
    {

    }
    

    void Update()
    {

        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float nitroAmount = Input.GetButton("Jump") ? acceleration : 1;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount * 0.01f * nitroAmount, 0);

    }
}