using UnityEngine;


public class Delivery : MonoBehaviour
{

    [SerializeField] float delay = 0.5f;                //Set the delay to 0.5 seconds
    [SerializeField] Color32 hasPackageColor = new Color32(221, 122, 18, 255); //Set the package color
    [SerializeField] Color32 noPackageColor = new Color32(255, 1, 1, 255); //Set the no package color
    SpriteRenderer spriteRenderer;
    bool hasPackage;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //Get the SpriteRenderer component
                 //Set the package color
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Collision detected with " + other.gameObject.name);
    }
    //Trigger method: it detects when the object collides with something
    //Needs to activate the Is Trigger in Box Collider Component
    void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");            //Log "Package picked up!"
            hasPackage = true;                          //Set hasPackage to true
            Destroy(other.gameObject, delay);           //Destroy the package
            spriteRenderer.color = hasPackageColor;     //Set the package color
            //spriteRenderer.sprite = Resources.Load<Sprite>("Car 3_nitro");            

        }
        else if (other.tag == "Package" && hasPackage)  //If the package has already been picked up
        {
            Debug.Log("You already have a package, deliver it first!");
        }

        if (other.tag == "Person" && hasPackage)
        {
            Debug.Log("Package Delivered!");            //Log "Package Delivered!"
            hasPackage = false;                         //Set hasPackage to false
            spriteRenderer.color = noPackageColor;      //Set the no package color
        }

    }
}
