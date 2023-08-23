using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f; //force being applied to the player forward movement
    public float sidewaysForce = 500f; //force being applied to the player's left/right movement
    public float jumpForce = 10f; //force being applied when a player jumps

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.GetKeyDown(KeyCode.Space) && rb.position.y < 1.02f)
        {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }    
    }
}