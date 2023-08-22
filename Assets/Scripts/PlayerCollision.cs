using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle" || collision.collider.tag == "TransparentObstacle" ||
            collision.collider.tag == "MovingObstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}