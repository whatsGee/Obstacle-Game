using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;    // Rigidbody of the player.
    private int count;
    
     // Movement along X and Y axes.
    private float movementX;
    private float movementY;
    public float speed = 0;   // Speed at which the player moves.
    public TextMeshProUGUI countText;   // UI text component to display count of "PickUp" objects collected.
    public GameObject winTextObject;     // UI object to display winning text.

    //float xValue = 0;
    //float yValue = 0.5f;
    //float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody>();    // Get and store the Rigidbody component attached to the player.
        count = 0;   // Initialize count to zero.
        SetCountText(); // Update the count display.
        winTextObject.SetActive(false); // Initially set the win text to be inactive.
    }

    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();  // Convert the input value into a Vector2 for movement.
        
        // Store the X and Y components of the movement.
        movementX = movementVector.x; 
        movementY = movementVector.y;
    }

    // FixedUpdate is called once per fixed frame-rate frame.
   void FixedUpdate()
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);    // Create a 3D movement vector using the X and Y inputs.

        rb.AddForce(movement * speed);  // Apply force to the Rigidbody to move the player.
    }

    /*
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, Input.GetAxis("Vertical"));
    }
    */
    
    void OnTriggerEnter(Collider other)
    {
         // Check if the object the player collided with has the "PickUp" tag.
        if (other.gameObject.CompareTag("PickUp")) 
       {
        other.gameObject.SetActive(false);  // Deactivate the collided object (making it disappear).
        count = count + 1;  // Increment the count of "PickUp" objects collected.
        SetCountText();  // Update the count display.
       }
    /*
       if (other.gameObject.CompareTag("Walls"))
       {
        other.GetComponent<Renderer>().material.color = new Color(0f, 1f, 1f, 1f);
       }
    */
    }
    
    void SetCountText() 
   {
       countText.text =  "Count: " + count.ToString();

        if (count >= 10)
       {
           winTextObject.SetActive(true);
       }
   }
    

}
