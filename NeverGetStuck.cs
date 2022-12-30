using UnityEngine;

public class NeverGetStuck : MonoBehaviour
{
    // The player's rigidbody
    private Rigidbody rb;

    // The player's input
    private Vector2 input;

    //The player input script
    private FPSRigidBodyWalker walker;

    // Number of seconds player is stationary
    private float stuckTime = 0f;

    // Number of seconds before player is considered stuck
    private const float stuckThreshold = 0.5f; 

    private void Awake()
    {
        // Get the player's rigidbody and collider
        rb = GetComponent<Rigidbody>();
        walker = GetComponent<FPSRigidBodyWalker>();
    }

    private void Update()
    {
        // Get the player's input
        input = new Vector2(walker.inputX, walker.inputY);

        // Check if the player is stuck
        CheckIfStuck();
    }

    private void CheckIfStuck()
    {
        // Adjust this value to suit your needs
        float velocityThreshold = 0.3f; 

        // If the player is trying to move and their velocity is near zero, they are stuck
        if (rb.velocity.magnitude < velocityThreshold && input != Vector2.zero)
        {
            // Increment the stuck time
            stuckTime += Time.deltaTime; 

            if (stuckTime >= stuckThreshold)
            {
                // The player has been stuck for over 1 second, so move the player slightly in a random direction
                rb.MovePosition(rb.position + Random.insideUnitSphere * 0.5f);

                // Reset the stuck time
                stuckTime = 0f; 
            }
        }
        else
        {
            // Reset the stuck time if the player is not stuck
            stuckTime = 0f; 
        }
    }
}
