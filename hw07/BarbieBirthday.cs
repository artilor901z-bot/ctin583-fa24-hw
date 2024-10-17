using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
Homework Problems

It is Barbie's Birthday and she is hosting a birthday party!
We are in a 2D World celebrating Barbie's Birthday and we are getting ready to break the pinata. 
First, we would like to position Barbie and the pinata correctly. 

Barbie is 5'9'' or 1.75 meters tall. 
She is standing 2 feet or 0.6 meters away from the her party pinata.
The party pinata is hanging 8.2 feet or 2.5 meters high from the ground.
Assume that the angles between the distance of the pinata to the ground and Barbie's distance to the pinata create a 90 degree angle. 

TODO: Problem 1: Barbie is holding a bat to swing at the pinata. What should be the magnitude the bat should swing at? Make sure the check for edge cases including:
     * Barbie has only three chances to swing at the pinata before it is the next player's turn
     * If Barbie runs out of turns, a message should display that Barbie's turn is over and it is the next player's turn
*/ 


//Answer 1:
public class BarbieBirthday : MonoBehaviour
{
    // Transform for Barbie's party pinata
    [SerializeField] Transform pinata; 

    // The pinata's rotation along the X axis for the first successful hit (Quaternion)
    [SerializeField] Quaternion rotationX;

    // The pinata's rotation along the Y axis for the second successful hit (Quaternion)
    [SerializeField] Quaternion rotationY;

    // Particle System for the third successful hit
    [SerializeField] ParticleSystem candyExplosion;

    // Barbie's height is Barbie is 5'9'' or 1.75 meters tall

    //Compare with Vector2, I think float is more direct for defining height?(I'm not sure)
    private Vector2 barbieHeight=new Vector2(0, 1.75f);

    // Barbie is standing 2 feet or 0.6 meters away from the her party pinata
    private Vector2 barbieToPinataDistance= new Vector2(0.6f, 0);   

    // The party pinata is hanging 8.2 feet or 2.5 meters high from the ground
    private Vector2 pinataHeight = new Vector2(0, 2.5f);

    private int countSwing = 0;
    private int maxSwing = 3;

    private void Start()
    {
        // the magnitude the bat should swing at
        float swingMagnitude = CalculateSwingMagnitude(barbieHeight, barbieToPinataDistance, pinataHeight);
    }
    // Update is called once per frame
    void Update()
    {
        if (CheckBarbieFacingPinata())
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SwingBat();
            }
        }

        Vector2 relativePosition = pinata.position - pinata.position;

        /*
        TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
        If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
            * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
            * Example: result = Quaternion.Euler(0,rotation, 0) * result;
            * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
            * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?
        */
    }

    /*
    TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
    Check to make sure that Barbie is facing directly at the pinata. 
    * Hint: The target should be the pinata
    * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector
   */

    //Answer 2:
    private bool CheckBarbieFacingPinata()
    {
        //check if Barbie is facing the pinata
        transform.LookAt(pinata);
        Vector2 directionToPinata = (pinata.position - transform.position).normalized;
        Vector2 barbieForward = transform.up;
        float angle = Vector2.Angle(directionToPinata, barbieForward);
        return angle < 10f;
    }


    private float CalculateSwingMagnitude(Vector2 barbieHeight, Vector2 barbieToPinataDistance, Vector2 pinataHeight)
    {
        //first,I calculate the vertical offset between Barbie and the pinata
        float verticalDistance = pinataHeight.y - barbieHeight.y;
        //then,I calculate the horizontal offset between Barbie and the pinata
        float horizontalDistance = barbieToPinataDistance.x;
        //by using two result above, I can calculate the magnitude of the bat should swing at by using Pythagorean theorem
        return Mathf.Sqrt(Mathf.Pow(verticalDistance, 2) + Mathf.Pow(horizontalDistance, 2));
    }


    //Answer 1 and 3:
    void SwingBat()
    {
        if (countSwing < maxSwing)
        {
            countSwing++;
            Debug.Log("Barbie swings the bat! Swing count: " + countSwing);

            // Check for successful hits and apply effects
            if (countSwing == 1)
            {
                pinata.rotation = rotationX;
                Debug.Log("Barbie first swing");
            }
            else if (countSwing == 2)
            {
                // Rotate the pinata along the x and y axis at the same time
                pinata.rotation = rotationX*rotationY;
                Debug.Log("Barbie second swing");
            }
            else if (countSwing == 3)
            {
                candyExplosion.Play();
                Debug.Log("LAST SWING");
                Debug.Log("Barbie has successfully hit the pinata! Candy explosion!");
            }

            //using slerp to rotate the pinata

            pinata.rotation = Quaternion.Slerp(pinata.rotation, pinata.rotation, Time.deltaTime * 5f);
        }
        else
        {
            Debug.Log("Barbie's turned over, the next player please!!!");
        }
    }
}