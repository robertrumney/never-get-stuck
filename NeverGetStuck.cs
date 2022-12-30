using UnityEngine;

public class NeverGetStuck : MonoBehaviour
{
    // The player's rigidbody
    private Rigidbody rb;

    // The player's input
    private Vector2 input;

    void Start()
    {
        // Get the player's rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get the player's input from the horizontal and vertical axis
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Check if the player is stuck
        CheckIfStuck();
    }

    // Check if the player is stuck by comparing the player's velocity to their input
    void CheckIfStuck()
    {
        float velocityThreshold = 0.3f; // Adjust this value to suit your needs

        // If the player is trying to move and their velocity is near zero, they are stuck
        if (rb.velocity.magnitude < velocityThreshold && input != Vector2.zero)
        {
            // The player is stuck, so move the player slightly in a random direction
            rb.MovePosition(rb.position + Random.insideUnitSphere * 0.2f);
        }
    }
}
