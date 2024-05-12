using UnityEngine;

public class nitroAppear : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetButton("Jump") == false)
        {
            spriteRenderer.sprite = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            spriteRenderer.sprite = Resources.Load<Sprite>("nitro");
        }
        else
        {
            spriteRenderer.sprite = null;
        }
    }
}
