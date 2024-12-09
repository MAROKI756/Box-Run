using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // "rb" stands for Ridgidbody
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // I used "Fixed"Update" 
    // because we are using it to mess with the physics
    void FixedUpdate()
    {
        // I added forward force

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
