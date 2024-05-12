using UnityEngine;

public class nitroAppear : MonoBehaviour
{

    [SerializeField] Color32 nitroOn = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 nitroOf = new Color32(255, 255, 255, 0);
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetButton("Jump") == false)
        {
            spriteRenderer.color = nitroOf;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            spriteRenderer.color = nitroOn;
        }
        else
        {
            spriteRenderer.color = nitroOf;
        }
    }
}
