using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

/* 
******************************************************************************************************
    Problem 1: TODO: Finish the case statements for each collectible item listed in CollectibleItems.cs

    Problem 2: TODO: Currently each case statement is written as a string. Enums are especially helpful 
    in preventing spelling mistakes. Instead of using strings sucn as "Enemy" and "Gem", lets use an enum. 
    Please modify each case statement to use an enum instead. 

    Problem 3: TODO: Define a normal tuple and a value tuple. When would you use a value tuple? 
    Print out each value in your defined tuple with Debug.Log

    Problem 4: TODO: Define a new enum within this file taking in different types of particles. 
    Examples include: FireParticles, GoldRibbons, Snowflakes, RainParticles, etc. 

    Problem 5: TODO: 
        * When would you use a tuple over a struct?  (tuple vs struct)
        //Answer: Compared to a struct, a tuple is more lightweight and is used to store a collection of values.
        //When we need to return multiple values from a method, we can use a tuple.

        * How do we acces items in a tuple?
        //Answer: We can access items in a tuple by using the Item1, Item2, Item3, like what I did in CollectibleItems.cs

        * Try visualizing your enum in the Unity Editor. How does it appear as?
        //Answer: The enum appears as a dropdown list in the Unity Editor.
        //It shows in a dropdown list. Which is good to help me to see the options of the object.
        
******************************************************************************************************
*/
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ParticleSystem enemyParticles;
    [SerializeField] private CollectibleItems collectibles; 

    private void OnCollisionEnter(Collision collision) {
        switch (collision.gameObject.tag) {
            case "Enemy":
                Destroy(gameObject);
                break;

            case "Gem":
                meshRenderer.material = collision.gameObject.GetComponent<Renderer>().material;
                Destroy(collision.gameObject);
                PlayParticles();
                break;

            default:
                break;
        }
    }

    // Check to make sure our value is defined
    private bool IsCollectibleItem(CollectibleItems collectible) {
        return (collectibles & collectible) != 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Set the tag based on the enum
        gameObject.tag = collectibles.ToString();
    }
}
